namespace System.Net.Security;

internal static class CertificateHelper
{

	internal static X509Certificate2 GetEligibleClientCertificate(X509CertificateCollection candidateCerts) { }

	internal static X509Certificate2 GetEligibleClientCertificate(X509Certificate2Collection candidateCerts) { }

	internal static X509Certificate2 GetEligibleClientCertificate() { }

	private static bool IsValidClientCertificate(X509Certificate2 cert) { }

	private static bool IsValidForClientAuthenticationEKU(X509EnhancedKeyUsageExtension eku) { }

	private static bool IsValidForDigitalSignatureUsage(X509KeyUsageExtension ku) { }

}

