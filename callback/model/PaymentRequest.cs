namespace callback.model
{
    public class PaymentRequest
    {
        public int? id { get; set; }
        public int? merchant_id { get; set; }
        public string? order_id { get; set; }
        public bool? accepted { get; set; }
        public string? type { get; set; }
        public string? text_on_statement { get; set; }
        public object? branding_id { get; set; }
        public Dictionary<string, object>? variables { get; set; }
        public string? currency { get; set; }
        public string? state { get; set; }
        public Metadata? metadata { get; set; }
        public Link? link { get; set; }
        public object? shipping_address { get; set; }
        public object? invoice_address { get; set; }
        public List<object>? basket { get; set; }
        public object? shipping { get; set; }
        public List<Operation>? operations { get; set; }
        public bool? test_mode { get; set; }
        public string? acquirer { get; set; }
        public object? facilitator { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }
        public object? retented_at { get; set; }
        public int? balance { get; set; }
        public object? fee { get; set; }
        public object? deadline_at { get; set; }
    }

    public class Metadata
    {
        public string? type { get; set; }
        public string? origin { get; set; }
        public string? brand { get; set; }
        public string? bin { get; set; }
        public string? last4 { get; set; }
        public int? exp_month { get; set; }
        public int? exp_year { get; set; }
        public string? country { get; set; }
        public bool? is_3d_secure { get; set; }
        public object? issued_to { get; set; }
        public string? hash { get; set; }
        public object? number { get; set; }
        public string? customer_ip { get; set; }
        public string? customer_country { get; set; }
        public bool? fraud_suspected { get; set; }
        public List<object>? fraud_remarks { get; set; }
        public bool? fraud_reported { get; set; }
        public object? fraud_report_description { get; set; }
        public object? fraud_reported_at { get; set; }
        public object? nin_number { get; set; }
        public object? nin_country_code { get; set; }
        public object? nin_gender { get; set; }
        public object? shopsystem_name { get; set; }
        public object? shopsystem_version { get; set; }
    }
    public class Operation
    {
        public int? id { get; set; }
        public string? type { get; set; }
        public int? amount { get; set; }
        public bool? pending { get; set; }
        public string? qp_status_code { get; set; }
        public string? qp_status_msg { get; set; }
        public string? aq_status_code { get; set; }
        public string? aq_status_msg { get; set; }
        public Data? data { get; set; }
        public string? callback_url { get; set; }
        public bool? callback_success { get; set; }
        public string? callback_response_code { get; set; }
        public int? callback_duration { get; set; }
        public string? acquirer { get; set; }
        public DateTime? callback_at { get; set; }
        public DateTime? created_at { get; set; }
    }
    public class Root
    {
        public int? id { get; set; }
        public int? merchant_id { get; set; }
        public string? order_id { get; set; }
        public bool? accepted { get; set; }
        public string? type { get; set; }
        public object? text_on_statement { get; set; }
        public object? branding_id { get; set; }
        public Variables? variables { get; set; }
        public string? currency { get; set; }
        public string? state { get; set; }
        public Metadata? metadata { get; set; }
        public Link? link { get; set; }
        public object? shipping_address { get; set; }
        public object? invoice_address { get; set; }
        public List<object>? basket { get; set; }
        public object? shipping { get; set; }
        public List<Operation>? operations { get; set; }
        public bool? test_mode { get; set; }
        public string? acquirer { get; set; }
        public object? facilitator { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }
        public object? retented_at { get; set; }
        public int? balance { get; set; }
        public object? fee { get; set; }
        public object? deadline_at { get; set; }
    }


    public class Variables
    {
    }
    public class BrandingConfig
    {
    }

    public class Data
    {
    }

    public class Link
    {
        public string? url { get; set; }
        public int? agreement_id { get; set; }
        public string? language { get; set; }
        public int? amount { get; set; }
        public object? continue_url { get; set; }
        public object? cancel_url { get; set; }
        public string? callback_url { get; set; }
        public string payment_methods { get; set; }
        public bool? auto_fee { get; set; }
        public object? auto_capture { get; set; }
        public object? branding_id { get; set; }
        public object? google_analytics_client_id { get; set; }
        public object? google_analytics_tracking_id { get; set; }
        public string? version { get; set; }
        public object? acquirer { get; set; }
        public object? deadline { get; set; }
        public bool? framed { get; set; }
        public BrandingConfig? branding_config { get; set; }
        public object? invoice_address_selection { get; set; }
        public object? shipping_address_selection { get; set; }
        public object? customer_email { get; set; }
    }

}