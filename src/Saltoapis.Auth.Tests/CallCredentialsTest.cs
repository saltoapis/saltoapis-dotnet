using System;
using System.Threading.Tasks;
using Grpc.Core;
using NUnit.Framework;
using Saltoapis.Auth;

namespace workspace.Tests
{
    [TestFixture]
    public class CallCredentialsTest
    {
        MockServiceHelper helper;
        Server server;
        Channel channel;

        [SetUp]
        public void Init()
        {
            helper = new MockServiceHelper(
                serverCredentials: TestTlsCredentials.ServerCredentials);

            server = helper.GetServer();
            server.Start();
        }

        [TearDown]
        public void Cleanup()
        {
            channel.ShutdownAsync().Wait();
            server.ShutdownAsync().Wait();
        }

        [Test]
        public async Task CallCredentials_AddsAuthorizationHeaders()
        {
            // having: secure server unary handler and call credentials
            var authorization_received = false;
            string credentials = "any_credentials";
            TestCredentialsProvider credentialsProvider = new TestCredentialsProvider(credentials);

            helper.UnaryHandler = new UnaryServerMethod<string, string>((request, context) =>
            {
                authorization_received = TestAuthHelpers.MetadataContainsAuth(context.RequestHeaders, credentials);

                return Task.FromResult("result");
            });

            channel = helper.SetChannelCredentials(
                ChannelCredentials.Create(
                    new SslCredentials(TestTlsCredentials.Certificate),
                    SaltoapisCallCredentials.FromTokenProvider(credentialsProvider)));

            // when
            CallInvoker invoker = channel.CreateCallInvoker();
            await helper.CreateAsyncUnaryCall(invoker, "request").ResponseAsync;

            // then
            Assert.True(authorization_received);
        }
    }

    internal static class TestTlsCredentials
    {
        internal const string Certificate = @"-----BEGIN CERTIFICATE-----
MIIBlDCCATmgAwIBAgIUR2TZNG1Osy7DTp4jmqTrr8pmZ44wCgYIKoZIzj0EAwIw
FDESMBAGA1UEAwwJbG9jYWxob3N0MB4XDTI2MDkyMTEwMzQzN1oXDTM2MDkxODEw
MzQzN1owFDESMBAGA1UEAwwJbG9jYWxob3N0MFkwEwYHKoZIzj0CAQYIKoZIzj0D
AQcDQgAEycvvaGRJBzHLDKdrytIvNR3wXu8DE5HGhxv+WUU64nhMH5T2r65YDNBD
WOiQ9EY35gORDTLydms8Yvn0G3uyjKNpMGcwHQYDVR0OBBYEFKvviez0X1AWxX4n
ln0Kw2Y6hfMSMB8GA1UdIwQYMBaAFKvviez0X1AWxX4nln0Kw2Y6hfMSMA8GA1Ud
EwEB/wQFMAMBAf8wFAYDVR0RBA0wC4IJbG9jYWxob3N0MAoGCCqGSM49BAMCA0kA
MEYCIQCg4UpCtrU/uathXnFvYDzXAOrcnW6OjZ5zfwEAkhzYeQIhAJN4nIccmuBh
6p+N/q8eXqyCzvxosBsIoGCv8YQ1wsR4
-----END CERTIFICATE-----";

        private const string PrivateKey = @"-----BEGIN EC PRIVATE KEY-----
MHcCAQEEIERFE6cfAZIVvUeBHYThILm4ZJHy1fj1mHMWGDvn/ATgoAoGCCqGSM49
AwEHoUQDQgAEycvvaGRJBzHLDKdrytIvNR3wXu8DE5HGhxv+WUU64nhMH5T2r65Y
DNBDWOiQ9EY35gORDTLydms8Yvn0G3uyjA==
-----END EC PRIVATE KEY-----";

        internal static readonly ServerCredentials ServerCredentials = new SslServerCredentials(
            new[] { new KeyCertificatePair(Certificate, PrivateKey) });
    }
}
