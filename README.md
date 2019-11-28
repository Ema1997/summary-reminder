#### summary reminder 总结提醒
##### 设计初衷
每天写总结回顾一下每天都干了什么，并按照所做事情写下反思，反思哪些做得对，哪些做的不对，哪些地方可以改进，如何改进，可以使自己每一天都有进步。然而最开始每天都想不起来写hhhhhh。所以就自己写了一个总结提醒的APP，定时启动，提醒我要开始写总结了。
##### 功能
<font color=#FE4C40>这个程序可以使得使用者强制停止当前工作，开始写总结。</font>
1. 配合计算机的计划任务工具可以定时开启。
2. 捕获鼠标，使得鼠标只能出现在程序界面范围，只有在退出程序后，鼠标才能出现在程序范围之外。
3. 点击“打开Word”选项后，会自动打开word程序，开始写总结。
4. 显示在所有程序的最上方，起到强提醒的作用。
##### 程序界面
<img src="https://img-blog.csdnimg.cn/20191128182022866.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L0VtYTE5OTc=,size_16,color_FFFFFF,t_70" width = "400" alt="图片名称" align=center>

##### 使用步骤（Win 10）
1. 从github下载源代码与程序，链接：https://github.com/Ema1997/summary-reminder.git
2. 搜索计划任务程序并打开
<img src="https://img-blog.csdnimg.cn/2019112818221628.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L0VtYTE5OTc=,size_16,color_FFFFFF,t_70"  alt="图片名称" align=center>

3. 点击创建任务
<img src="https://img-blog.csdnimg.cn/20191128182952826.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L0VtYTE5OTc=,size_16,color_FFFFFF,t_70"  alt="图片名称" align=center>

4. 任务配置
此处名称为写总结。
<img src="https://img-blog.csdnimg.cn/20191128183917588.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L0VtYTE5OTc=,size_16,color_FFFFFF,t_70" width = 60% alt="图片名称" align=center>

设置触发器，此处设置为了每天晚上21：00执行任务。
<img src="https://img-blog.csdnimg.cn/2019112818463968.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L0VtYTE5OTc=,size_16,color_FFFFFF,t_70" alt="图片名称" align=center>

新建操作，第一个操作是强制停止现在的工作（这个地方有点小trick，微笑）
<img src="https://img-blog.csdnimg.cn/20191128184952429.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L0VtYTE5OTc=,size_16,color_FFFFFF,t_70" alt="图片名称" align=center>

第二个操作是执行总结提醒APP.exe。这两个操作中要启动的程序都包含在从github链接下载的文件中。
<img src="https://img-blog.csdnimg.cn/20191128184810798.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L0VtYTE5OTc=,size_16,color_FFFFFF,t_70" alt="图片名称" align=center>

5. 用写字板打开form1.cs文件，并修改红框中路径为所想要打开的编辑器的可执行程序，此处打开的是我的Word。
<img src="https://img-blog.csdnimg.cn/20191128201021121.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L0VtYTE5OTc=,size_16,color_FFFFFF,t_70" width = 70% alt="图片名称" align=center>

6. 之后就等到触发器设定的时间就可以感受一下强制写总结的感觉了。
---
hhhhhhhh。如果哪天心情好把代码也解析一下，是用C#写的，很简单但对于我来说很实用。