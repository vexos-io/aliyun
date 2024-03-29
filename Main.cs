using Aliyun;

if(args.Length != 5)
  throw new ArgumentException("arguments error: $key $secret $record $prefix $ip");

var domain = new Domain
{
  key = args[0],
  secret = args[1]
};

domain.Update(args[2], args[3], args[4]);
