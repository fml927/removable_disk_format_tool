﻿#README

[![Codacy Badge](https://api.codacy.com/project/badge/Grade/44312b969e784d65a3ba91fab6180132)](https://www.codacy.com/app/fml927/removable_disk_format_tool?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=fml927/removable_disk_format_tool&amp;utm_campaign=badger)

开发环境：Visua Studio 2010

此工具目标是合并移动设备上的分区，全部容量还原，并使u盘回到没有格式化的初始状态。

此工具是一个多年前自己写的U盘格式化工具，为了解决经常有些客户拿着被各种分区和格式化出问题的u盘在设备上识别或者使用出错的问题。

**！！！使用这个工具格式化后的u盘将上出全部U盘上的现有数据！！！**

**数据无价，使用请谨慎，不对存储设备上的数据安全性和设备本身的安全做出任何保证**

**非专业人士不推荐使用**

这个工具的目标：
* 基于windows，能动识别出可移动存储设备,比如:U盘
* 不论当前U盘被分为多少个区或内置哪种文件系统，本工具直接操作物理磁盘，自动修改合并分区信息，保证只有一个主分区。并清除文件系统信息。
* 基于上面的原因，本工具格式化完成后，需要再次插拔。然后系统会发现一个没有被格式化的可移动设备，这时再根据自己的需要按照系统提示格式化移动设备即可。

**如果你还不明白磁盘和文件系统的区别的话，不建议使用此工具**

**Geeker & DIY爱好者技术交流，可以直接再次系统交流问题或联系FML927@LIVE.com**
