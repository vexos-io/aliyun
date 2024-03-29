using AlibabaCloud.OpenApiClient.Models;
using AlibabaCloud.SDK.Alidns20150109;
using AlibabaCloud.SDK.Alidns20150109.Models;

namespace Aliyun;

//阿里云域名管理
public class Domain
{
  private readonly Client client;
  public required string key { get; init; }
  public required string secret { get; init; }

  public Domain()
  {
    client = new Client(new Config
    {
      Endpoint = "alidns.cn-hangzhou.aliyuncs.com",
      AccessKeyId = key,
      AccessKeySecret = secret
    });
  }

  //更新域名解析
  public void Update(string record, string prefix, string ip)
  {
    client.UpdateDomainRecord(new UpdateDomainRecordRequest
    {
      RecordId = record,
      RR = prefix,
      Type = "A",
      Value = ip
    });
  }
}
