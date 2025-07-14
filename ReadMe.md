# AndroidApkSignHelper
简单的Android应用签名工具

## 签名文件夹配置
创建sign_info.txt文件保存常用的签名文件配置项。<br>
* 存放位置 <br>
存放在应用根目录；
* 数据格式 <br>
显示名称,存放签名文件的路径 <br>
例如：27签名,c:\27-签名文件

## 签名文件信息配置
在签名文件目录中创建“info.ini”文件，用来保存各个签名证书的别名，密码等信息。
* 例如 <br>
[签名证书文件全名]<br>
alias=别名<br>
store=库密码<br>
key=证书密码<br>
