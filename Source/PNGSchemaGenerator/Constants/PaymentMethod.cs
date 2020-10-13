namespace PNGSchemaGenerator.Constants
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaymentMethod
    {
        [EnumMember(Value = "http://purl.org/goodrelations/v1#ByBankTransferInAdvance")]
        ByBankTransferInAdvance,

        [EnumMember(Value = "http://purl.org/goodrelations/v1#ByInvoice")]
        ByInvoice,

        [EnumMember(Value = "http://purl.org/goodrelations/v1#Cash")]
        Cash,

        [EnumMember(Value = "http://purl.org/goodrelations/v1#COD")]
        COD,

        [EnumMember(Value = "http://purl.org/goodrelations/v1#DirectDebit")]
        DirectDebit,

        [EnumMember(Value = "http://purl.org/goodrelations/v1#GoogleCheckout")]
        GoogleCheckout,

        [EnumMember(Value = "http://purl.org/goodrelations/v1#PayPal")]
        Paypal
    }
}
