# RedirectProfile

只在linux上测试过  
only in Linux  

### 功能
将mod存档重定向到原存档

### 使用方法
解压压缩包, 将dll和json文件放入`~/.local/share/Steam/steamapps/common/Slay the Spire 2/mods`文件夹  
steam启动参数填`env LD_PRELOAD=/usr/lib64/libgcc_s.so.1 %command%`