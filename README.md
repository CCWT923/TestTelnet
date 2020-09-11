
一个简单的 `C#` 的Telnet客户端。 <br />

使用方法

``` C#
//创建连接对象
TelnetConnection telnet = new TelnetConnection("地址", "端口=23");
//登录，返回登录成功后的字符串
var s = telnet.Login("用户名", "密码", "延迟时间(不宜太长)");
//发送命令
telnet.WriteLine("命令字符串");
//读取
telnet.Read();
```
