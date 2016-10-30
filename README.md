## protobuf-for-purejsb

本项目在purejsb框架的基础上实现了protobuf热更新的方案  
C#端protobuf协议的序列化使用了protobuf.net  
js端protobuf协议的序列化使用了夜莺的解决方案  
在夜莺的基础上更进了一部，不在需要为了序列化protobuf去编写对应的cs文件  

因为原生protobuf.net工具生成的CS文件,无法直接用于JS热更新,所以对工具做了一些修改  
主要是修改了用于生成代码的protobuf-net.xml文件,使得工具导出的CS文件可以用于JS热更新  
修改后的转换工具在项目的ProtobuffTools目录中

这个项目主要是为大家在PureJsb使用protobuf提供一个新的思路  
欢迎大家提出更好的想法
  
测试使用的unity版本：5.3.5p6

##实现的特性：  
只使用protobuf.net生成的cs文件就可以实现protobuf序列化的操作  
使用同一套代码就可以即支持C#代码调试和又支持JS热更新

##存在的问题
生成的协议文件还不能支持引用其他的协议文件，不支持import

##参考资料
PureJsb：[https://github.com/linkabox/PureJSB](https://github.com/linkabox/PureJSB)  
[夜莺的Protobuf热更新解决方案](http://www.cnblogs.com/zyc-it/p/4881026.html)