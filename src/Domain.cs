using AlibabaCloud.OpenApiClient.Models;
using AlibabaCloud.SDK.Alidns20150109;
using AlibabaCloud.SDK.Alidns20150109.Models;

namespace Aliyun;

//阿里云域名管理
public class Domain
{
  public required string key { get; init; }
  public required string secret { get; init; }

  //更新域名解析
  public void Update(string record, string prefix, string ip)
  {
    var config = new Config
    {
      Endpoint = "alidns.cn-hangzhou.aliyuncs.com",
      AccessKeyId = key,
      AccessKeySecret = secret
    };
    var client = new Client(config);
    var req = new UpdateDomainRecordRequest
    {
      RecordId = record,
      RR = prefix,
      Type = "A",
      Value = ip
    };
    client.UpdateDomainRecord(req);
  }
}
