# AtawTestCloud
一个整合了Selenium的Net版前端自动化测试的后台代码。

# 2017.3.20 
1 请不要使用IIS启动网站，使用vs 自带的IISExpress来启动。这是因为再IIS中启动网站ChormeDriver.exe并不能再界面上显示浏览器。


2 再Application.xml 配置了两个字段 
```xml
<AppSetting Key="ChomeDriverPath" Value="F:\WebDeriver"/>
```
   ChormeDriver.exe的路径

```xml
<AppSetting Key="SeleniumMianUrl" Value="http://localhost:4676/rightcloud/auth/index/1"/> 
```
网站开始的第一个路径
# 2017.3.24
开始了


