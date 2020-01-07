# 创建日期：2019年12月17日18:26:13
# 简介：基于Python的文件传输服务
# 编写人：limo1029
# 软件：vim, VSCode, VS2019
# 附注：Client端
# 版权声明(C)limo1029


# 引用模块
import socket
import threading
from hashlib import sha256

# 构建socket实例
input()
Server_Address = ('192.168.26.1', 9000)
clienter = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
clienter.connect(Server_Address)
print(clienter.recv(1024))
input = input("模式：")
if (input == "1"):
    clienter.send(input("Username:"))
    clienter.send(input("Password:"))
elif (input == "2"):
    clienter.send(input("RootPassword"))
