// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/logging/v2/logging_metrics.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Logging.V2 {

  /// <summary>Holder for reflection information generated from google/logging/v2/logging_metrics.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class LoggingMetricsReflection {

    #region Descriptor
    /// <summary>File descriptor for google/logging/v2/logging_metrics.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LoggingMetricsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cidnb29nbGUvbG9nZ2luZy92Mi9sb2dnaW5nX21ldHJpY3MucHJvdG8SEWdv",
            "b2dsZS5sb2dnaW5nLnYyGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3Rv",
            "Ghtnb29nbGUvcHJvdG9idWYvZW1wdHkucHJvdG8iPgoJTG9nTWV0cmljEgwK",
            "BG5hbWUYASABKAkSEwoLZGVzY3JpcHRpb24YAiABKAkSDgoGZmlsdGVyGAMg",
            "ASgJIlQKFUxpc3RMb2dNZXRyaWNzUmVxdWVzdBIUCgxwcm9qZWN0X25hbWUY",
            "ASABKAkSEgoKcGFnZV90b2tlbhgCIAEoCRIRCglwYWdlX3NpemUYAyABKAUi",
            "YAoWTGlzdExvZ01ldHJpY3NSZXNwb25zZRItCgdtZXRyaWNzGAEgAygLMhwu",
            "Z29vZ2xlLmxvZ2dpbmcudjIuTG9nTWV0cmljEhcKD25leHRfcGFnZV90b2tl",
            "bhgCIAEoCSIqChNHZXRMb2dNZXRyaWNSZXF1ZXN0EhMKC21ldHJpY19uYW1l",
            "GAEgASgJIlwKFkNyZWF0ZUxvZ01ldHJpY1JlcXVlc3QSFAoMcHJvamVjdF9u",
            "YW1lGAEgASgJEiwKBm1ldHJpYxgCIAEoCzIcLmdvb2dsZS5sb2dnaW5nLnYy",
            "LkxvZ01ldHJpYyJbChZVcGRhdGVMb2dNZXRyaWNSZXF1ZXN0EhMKC21ldHJp",
            "Y19uYW1lGAEgASgJEiwKBm1ldHJpYxgCIAEoCzIcLmdvb2dsZS5sb2dnaW5n",
            "LnYyLkxvZ01ldHJpYyItChZEZWxldGVMb2dNZXRyaWNSZXF1ZXN0EhMKC21l",
            "dHJpY19uYW1lGAEgASgJMvkFChBNZXRyaWNzU2VydmljZVYyEpkBCg5MaXN0",
            "TG9nTWV0cmljcxIoLmdvb2dsZS5sb2dnaW5nLnYyLkxpc3RMb2dNZXRyaWNz",
            "UmVxdWVzdBopLmdvb2dsZS5sb2dnaW5nLnYyLkxpc3RMb2dNZXRyaWNzUmVz",
            "cG9uc2UiMoLT5JMCLBIqL3YyYmV0YTEve3Byb2plY3RfbmFtZT1wcm9qZWN0",
            "cy8qfS9tZXRyaWNzEokBCgxHZXRMb2dNZXRyaWMSJi5nb29nbGUubG9nZ2lu",
            "Zy52Mi5HZXRMb2dNZXRyaWNSZXF1ZXN0GhwuZ29vZ2xlLmxvZ2dpbmcudjIu",
            "TG9nTWV0cmljIjOC0+STAi0SKy92MmJldGExL3ttZXRyaWNfbmFtZT1wcm9q",
            "ZWN0cy8qL21ldHJpY3MvKn0SlgEKD0NyZWF0ZUxvZ01ldHJpYxIpLmdvb2ds",
            "ZS5sb2dnaW5nLnYyLkNyZWF0ZUxvZ01ldHJpY1JlcXVlc3QaHC5nb29nbGUu",
            "bG9nZ2luZy52Mi5Mb2dNZXRyaWMiOoLT5JMCNCIqL3YyYmV0YTEve3Byb2pl",
            "Y3RfbmFtZT1wcm9qZWN0cy8qfS9tZXRyaWNzOgZtZXRyaWMSlwEKD1VwZGF0",
            "ZUxvZ01ldHJpYxIpLmdvb2dsZS5sb2dnaW5nLnYyLlVwZGF0ZUxvZ01ldHJp",
            "Y1JlcXVlc3QaHC5nb29nbGUubG9nZ2luZy52Mi5Mb2dNZXRyaWMiO4LT5JMC",
            "NRorL3YyYmV0YTEve21ldHJpY19uYW1lPXByb2plY3RzLyovbWV0cmljcy8q",
            "fToGbWV0cmljEokBCg9EZWxldGVMb2dNZXRyaWMSKS5nb29nbGUubG9nZ2lu",
            "Zy52Mi5EZWxldGVMb2dNZXRyaWNSZXF1ZXN0GhYuZ29vZ2xlLnByb3RvYnVm",
            "LkVtcHR5IjOC0+STAi0qKy92MmJldGExL3ttZXRyaWNfbmFtZT1wcm9qZWN0",
            "cy8qL21ldHJpY3MvKn1CGQoVY29tLmdvb2dsZS5sb2dnaW5nLnYyUAFiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedCodeInfo(null, new pbr::GeneratedCodeInfo[] {
            new pbr::GeneratedCodeInfo(typeof(global::Google.Logging.V2.LogMetric), global::Google.Logging.V2.LogMetric.Parser, new[]{ "Name", "Description", "Filter" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::Google.Logging.V2.ListLogMetricsRequest), global::Google.Logging.V2.ListLogMetricsRequest.Parser, new[]{ "ProjectName", "PageToken", "PageSize" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::Google.Logging.V2.ListLogMetricsResponse), global::Google.Logging.V2.ListLogMetricsResponse.Parser, new[]{ "Metrics", "NextPageToken" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::Google.Logging.V2.GetLogMetricRequest), global::Google.Logging.V2.GetLogMetricRequest.Parser, new[]{ "MetricName" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::Google.Logging.V2.CreateLogMetricRequest), global::Google.Logging.V2.CreateLogMetricRequest.Parser, new[]{ "ProjectName", "Metric" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::Google.Logging.V2.UpdateLogMetricRequest), global::Google.Logging.V2.UpdateLogMetricRequest.Parser, new[]{ "MetricName", "Metric" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::Google.Logging.V2.DeleteLogMetricRequest), global::Google.Logging.V2.DeleteLogMetricRequest.Parser, new[]{ "MetricName" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///  Describes a logs-based metric.  The value of the metric is the
  ///  number of log entries that match a logs filter.
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class LogMetric : pb::IMessage<LogMetric> {
    private static readonly pb::MessageParser<LogMetric> _parser = new pb::MessageParser<LogMetric>(() => new LogMetric());
    public static pb::MessageParser<LogMetric> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Logging.V2.LoggingMetricsReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public LogMetric() {
      OnConstruction();
    }

    partial void OnConstruction();

    public LogMetric(LogMetric other) : this() {
      name_ = other.name_;
      description_ = other.description_;
      filter_ = other.filter_;
    }

    public LogMetric Clone() {
      return new LogMetric(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    ///  Required. The client-assigned metric identifier. Example:
    ///  `"severe_errors"`.  Metric identifiers are limited to 1000
    ///  characters and can include only the following characters: `A-Z`,
    ///  `a-z`, `0-9`, and the special characters `_-.,+!*',()%/\`.  The
    ///  forward-slash character (`/`) denotes a hierarchy of name pieces,
    ///  and it cannot be the first character of the name.
    /// </summary>
    public string Name {
      get { return name_; }
      set {
        name_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 2;
    private string description_ = "";
    /// <summary>
    ///  A description of this metric, which is used in documentation.
    /// </summary>
    public string Description {
      get { return description_; }
      set {
        description_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "filter" field.</summary>
    public const int FilterFieldNumber = 3;
    private string filter_ = "";
    /// <summary>
    ///  An [advanced logs filter](/logging/docs/view/advanced_filters).
    ///  Example: `"logName:syslog AND severity>=ERROR"`.
    /// </summary>
    public string Filter {
      get { return filter_; }
      set {
        filter_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as LogMetric);
    }

    public bool Equals(LogMetric other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Description != other.Description) return false;
      if (Filter != other.Filter) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (Filter.Length != 0) hash ^= Filter.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Description);
      }
      if (Filter.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Filter);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (Filter.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Filter);
      }
      return size;
    }

    public void MergeFrom(LogMetric other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.Filter.Length != 0) {
        Filter = other.Filter;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            Description = input.ReadString();
            break;
          }
          case 26: {
            Filter = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  The parameters to ListLogMetrics.
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class ListLogMetricsRequest : pb::IMessage<ListLogMetricsRequest> {
    private static readonly pb::MessageParser<ListLogMetricsRequest> _parser = new pb::MessageParser<ListLogMetricsRequest>(() => new ListLogMetricsRequest());
    public static pb::MessageParser<ListLogMetricsRequest> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Logging.V2.LoggingMetricsReflection.Descriptor.MessageTypes[1]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public ListLogMetricsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    public ListLogMetricsRequest(ListLogMetricsRequest other) : this() {
      projectName_ = other.projectName_;
      pageToken_ = other.pageToken_;
      pageSize_ = other.pageSize_;
    }

    public ListLogMetricsRequest Clone() {
      return new ListLogMetricsRequest(this);
    }

    /// <summary>Field number for the "project_name" field.</summary>
    public const int ProjectNameFieldNumber = 1;
    private string projectName_ = "";
    /// <summary>
    ///  Required. The resource name of the project containing the metrics.
    ///  Example: `"projects/my-project-id"`.
    /// </summary>
    public string ProjectName {
      get { return projectName_; }
      set {
        projectName_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "page_token" field.</summary>
    public const int PageTokenFieldNumber = 2;
    private string pageToken_ = "";
    /// <summary>
    ///  Optional. If the `pageToken` request parameter is supplied, then the next
    ///  page of results in the set are retrieved.  The `pageToken` parameter must
    ///  be set with the value of the `nextPageToken` result parameter from the
    ///  previous request.  The value of `projectName` must
    ///  be the same as in the previous request.
    /// </summary>
    public string PageToken {
      get { return pageToken_; }
      set {
        pageToken_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "page_size" field.</summary>
    public const int PageSizeFieldNumber = 3;
    private int pageSize_;
    /// <summary>
    ///  Optional. The maximum number of results to return from this request.  Fewer
    ///  results might be returned. You must check for the `nextPageToken` result to
    ///  determine if additional results are available, which you can retrieve by
    ///  passing the `nextPageToken` value in the `pageToken` parameter to the next
    ///  request.
    /// </summary>
    public int PageSize {
      get { return pageSize_; }
      set {
        pageSize_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as ListLogMetricsRequest);
    }

    public bool Equals(ListLogMetricsRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ProjectName != other.ProjectName) return false;
      if (PageToken != other.PageToken) return false;
      if (PageSize != other.PageSize) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (ProjectName.Length != 0) hash ^= ProjectName.GetHashCode();
      if (PageToken.Length != 0) hash ^= PageToken.GetHashCode();
      if (PageSize != 0) hash ^= PageSize.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (ProjectName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ProjectName);
      }
      if (PageToken.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(PageToken);
      }
      if (PageSize != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(PageSize);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (ProjectName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProjectName);
      }
      if (PageToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PageToken);
      }
      if (PageSize != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PageSize);
      }
      return size;
    }

    public void MergeFrom(ListLogMetricsRequest other) {
      if (other == null) {
        return;
      }
      if (other.ProjectName.Length != 0) {
        ProjectName = other.ProjectName;
      }
      if (other.PageToken.Length != 0) {
        PageToken = other.PageToken;
      }
      if (other.PageSize != 0) {
        PageSize = other.PageSize;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            ProjectName = input.ReadString();
            break;
          }
          case 18: {
            PageToken = input.ReadString();
            break;
          }
          case 24: {
            PageSize = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  Result returned from ListLogMetrics.
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class ListLogMetricsResponse : pb::IMessage<ListLogMetricsResponse> {
    private static readonly pb::MessageParser<ListLogMetricsResponse> _parser = new pb::MessageParser<ListLogMetricsResponse>(() => new ListLogMetricsResponse());
    public static pb::MessageParser<ListLogMetricsResponse> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Logging.V2.LoggingMetricsReflection.Descriptor.MessageTypes[2]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public ListLogMetricsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    public ListLogMetricsResponse(ListLogMetricsResponse other) : this() {
      metrics_ = other.metrics_.Clone();
      nextPageToken_ = other.nextPageToken_;
    }

    public ListLogMetricsResponse Clone() {
      return new ListLogMetricsResponse(this);
    }

    /// <summary>Field number for the "metrics" field.</summary>
    public const int MetricsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Logging.V2.LogMetric> _repeated_metrics_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Logging.V2.LogMetric.Parser);
    private readonly pbc::RepeatedField<global::Google.Logging.V2.LogMetric> metrics_ = new pbc::RepeatedField<global::Google.Logging.V2.LogMetric>();
    /// <summary>
    ///  A list of logs-based metrics.
    /// </summary>
    public pbc::RepeatedField<global::Google.Logging.V2.LogMetric> Metrics {
      get { return metrics_; }
    }

    /// <summary>Field number for the "next_page_token" field.</summary>
    public const int NextPageTokenFieldNumber = 2;
    private string nextPageToken_ = "";
    /// <summary>
    ///  If there are more results than were returned, then `nextPageToken` is given
    ///  a value in the response.  To get the next batch of results, call this
    ///  method again using the value of `nextPageToken` as `pageToken`.
    /// </summary>
    public string NextPageToken {
      get { return nextPageToken_; }
      set {
        nextPageToken_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as ListLogMetricsResponse);
    }

    public bool Equals(ListLogMetricsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!metrics_.Equals(other.metrics_)) return false;
      if (NextPageToken != other.NextPageToken) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      hash ^= metrics_.GetHashCode();
      if (NextPageToken.Length != 0) hash ^= NextPageToken.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      metrics_.WriteTo(output, _repeated_metrics_codec);
      if (NextPageToken.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(NextPageToken);
      }
    }

    public int CalculateSize() {
      int size = 0;
      size += metrics_.CalculateSize(_repeated_metrics_codec);
      if (NextPageToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NextPageToken);
      }
      return size;
    }

    public void MergeFrom(ListLogMetricsResponse other) {
      if (other == null) {
        return;
      }
      metrics_.Add(other.metrics_);
      if (other.NextPageToken.Length != 0) {
        NextPageToken = other.NextPageToken;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            metrics_.AddEntriesFrom(input, _repeated_metrics_codec);
            break;
          }
          case 18: {
            NextPageToken = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  The parameters to GetLogMetric.
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class GetLogMetricRequest : pb::IMessage<GetLogMetricRequest> {
    private static readonly pb::MessageParser<GetLogMetricRequest> _parser = new pb::MessageParser<GetLogMetricRequest>(() => new GetLogMetricRequest());
    public static pb::MessageParser<GetLogMetricRequest> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Logging.V2.LoggingMetricsReflection.Descriptor.MessageTypes[3]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public GetLogMetricRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    public GetLogMetricRequest(GetLogMetricRequest other) : this() {
      metricName_ = other.metricName_;
    }

    public GetLogMetricRequest Clone() {
      return new GetLogMetricRequest(this);
    }

    /// <summary>Field number for the "metric_name" field.</summary>
    public const int MetricNameFieldNumber = 1;
    private string metricName_ = "";
    /// <summary>
    ///  The resource name of the desired metric.
    ///  Example: `"projects/my-project-id/metrics/my-metric-id"`.
    /// </summary>
    public string MetricName {
      get { return metricName_; }
      set {
        metricName_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as GetLogMetricRequest);
    }

    public bool Equals(GetLogMetricRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MetricName != other.MetricName) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (MetricName.Length != 0) hash ^= MetricName.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (MetricName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(MetricName);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (MetricName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MetricName);
      }
      return size;
    }

    public void MergeFrom(GetLogMetricRequest other) {
      if (other == null) {
        return;
      }
      if (other.MetricName.Length != 0) {
        MetricName = other.MetricName;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            MetricName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  The parameters to CreateLogMetric.
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class CreateLogMetricRequest : pb::IMessage<CreateLogMetricRequest> {
    private static readonly pb::MessageParser<CreateLogMetricRequest> _parser = new pb::MessageParser<CreateLogMetricRequest>(() => new CreateLogMetricRequest());
    public static pb::MessageParser<CreateLogMetricRequest> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Logging.V2.LoggingMetricsReflection.Descriptor.MessageTypes[4]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public CreateLogMetricRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    public CreateLogMetricRequest(CreateLogMetricRequest other) : this() {
      projectName_ = other.projectName_;
      Metric = other.metric_ != null ? other.Metric.Clone() : null;
    }

    public CreateLogMetricRequest Clone() {
      return new CreateLogMetricRequest(this);
    }

    /// <summary>Field number for the "project_name" field.</summary>
    public const int ProjectNameFieldNumber = 1;
    private string projectName_ = "";
    /// <summary>
    ///  The resource name of the project in which to create the metric.
    ///  Example: `"projects/my-project-id"`.
    ///
    ///  The new metric must be provided in the request.
    /// </summary>
    public string ProjectName {
      get { return projectName_; }
      set {
        projectName_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "metric" field.</summary>
    public const int MetricFieldNumber = 2;
    private global::Google.Logging.V2.LogMetric metric_;
    /// <summary>
    ///  The new logs-based metric, which must not have an identifier that
    ///  already exists.
    /// </summary>
    public global::Google.Logging.V2.LogMetric Metric {
      get { return metric_; }
      set {
        metric_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as CreateLogMetricRequest);
    }

    public bool Equals(CreateLogMetricRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ProjectName != other.ProjectName) return false;
      if (!object.Equals(Metric, other.Metric)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (ProjectName.Length != 0) hash ^= ProjectName.GetHashCode();
      if (metric_ != null) hash ^= Metric.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (ProjectName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ProjectName);
      }
      if (metric_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Metric);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (ProjectName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProjectName);
      }
      if (metric_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Metric);
      }
      return size;
    }

    public void MergeFrom(CreateLogMetricRequest other) {
      if (other == null) {
        return;
      }
      if (other.ProjectName.Length != 0) {
        ProjectName = other.ProjectName;
      }
      if (other.metric_ != null) {
        if (metric_ == null) {
          metric_ = new global::Google.Logging.V2.LogMetric();
        }
        Metric.MergeFrom(other.Metric);
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            ProjectName = input.ReadString();
            break;
          }
          case 18: {
            if (metric_ == null) {
              metric_ = new global::Google.Logging.V2.LogMetric();
            }
            input.ReadMessage(metric_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  The parameters to UpdateLogMetric.
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class UpdateLogMetricRequest : pb::IMessage<UpdateLogMetricRequest> {
    private static readonly pb::MessageParser<UpdateLogMetricRequest> _parser = new pb::MessageParser<UpdateLogMetricRequest>(() => new UpdateLogMetricRequest());
    public static pb::MessageParser<UpdateLogMetricRequest> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Logging.V2.LoggingMetricsReflection.Descriptor.MessageTypes[5]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public UpdateLogMetricRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    public UpdateLogMetricRequest(UpdateLogMetricRequest other) : this() {
      metricName_ = other.metricName_;
      Metric = other.metric_ != null ? other.Metric.Clone() : null;
    }

    public UpdateLogMetricRequest Clone() {
      return new UpdateLogMetricRequest(this);
    }

    /// <summary>Field number for the "metric_name" field.</summary>
    public const int MetricNameFieldNumber = 1;
    private string metricName_ = "";
    /// <summary>
    ///  The resource name of the metric to update.
    ///  Example: `"projects/my-project-id/metrics/my-metric-id"`.
    ///
    ///  The updated metric must be provided in the request and have the
    ///  same identifier that is specified in `metricName`.
    ///  If the metric does not exist, it is created.
    /// </summary>
    public string MetricName {
      get { return metricName_; }
      set {
        metricName_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "metric" field.</summary>
    public const int MetricFieldNumber = 2;
    private global::Google.Logging.V2.LogMetric metric_;
    /// <summary>
    ///  The updated metric, whose name must be the same as the
    ///  metric identifier in `metricName`. If `metricName` does not
    ///  exist, then a new metric is created.
    /// </summary>
    public global::Google.Logging.V2.LogMetric Metric {
      get { return metric_; }
      set {
        metric_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as UpdateLogMetricRequest);
    }

    public bool Equals(UpdateLogMetricRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MetricName != other.MetricName) return false;
      if (!object.Equals(Metric, other.Metric)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (MetricName.Length != 0) hash ^= MetricName.GetHashCode();
      if (metric_ != null) hash ^= Metric.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (MetricName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(MetricName);
      }
      if (metric_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Metric);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (MetricName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MetricName);
      }
      if (metric_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Metric);
      }
      return size;
    }

    public void MergeFrom(UpdateLogMetricRequest other) {
      if (other == null) {
        return;
      }
      if (other.MetricName.Length != 0) {
        MetricName = other.MetricName;
      }
      if (other.metric_ != null) {
        if (metric_ == null) {
          metric_ = new global::Google.Logging.V2.LogMetric();
        }
        Metric.MergeFrom(other.Metric);
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            MetricName = input.ReadString();
            break;
          }
          case 18: {
            if (metric_ == null) {
              metric_ = new global::Google.Logging.V2.LogMetric();
            }
            input.ReadMessage(metric_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  The parameters to DeleteLogMetric.
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class DeleteLogMetricRequest : pb::IMessage<DeleteLogMetricRequest> {
    private static readonly pb::MessageParser<DeleteLogMetricRequest> _parser = new pb::MessageParser<DeleteLogMetricRequest>(() => new DeleteLogMetricRequest());
    public static pb::MessageParser<DeleteLogMetricRequest> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Logging.V2.LoggingMetricsReflection.Descriptor.MessageTypes[6]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public DeleteLogMetricRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    public DeleteLogMetricRequest(DeleteLogMetricRequest other) : this() {
      metricName_ = other.metricName_;
    }

    public DeleteLogMetricRequest Clone() {
      return new DeleteLogMetricRequest(this);
    }

    /// <summary>Field number for the "metric_name" field.</summary>
    public const int MetricNameFieldNumber = 1;
    private string metricName_ = "";
    /// <summary>
    ///  The resource name of the metric to delete.
    ///  Example: `"projects/my-project-id/metrics/my-metric-id"`.
    /// </summary>
    public string MetricName {
      get { return metricName_; }
      set {
        metricName_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as DeleteLogMetricRequest);
    }

    public bool Equals(DeleteLogMetricRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MetricName != other.MetricName) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (MetricName.Length != 0) hash ^= MetricName.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (MetricName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(MetricName);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (MetricName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MetricName);
      }
      return size;
    }

    public void MergeFrom(DeleteLogMetricRequest other) {
      if (other == null) {
        return;
      }
      if (other.MetricName.Length != 0) {
        MetricName = other.MetricName;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            MetricName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
