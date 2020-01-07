# 创建日期：2019年12月17日18:26:13
# 简介：基于Python的文件传输服务
# 编写人：limo1029
# 软件：vim, VSCode, VS2019
# 附注：Server端
# 版权声明(C)limo1029


# 引用模块
import socket
import threading
from hashlib import sha256



# 获取本机IP
local_name = socket.getfqdn(socket.gethostname())
local_ip = socket.gethostbyname(local_name)


# 初始化 - 构建socket实例
listener = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
listener.setsockopt(socket.SOL_SOCKET,socket.SO_REUSEADDR,1)
listener.bind((local_ip, 9000))
listener.listen(5)
print('等待连接......')



# 声明依赖函数组

# 传输凭证验证（访问令牌）
def checking(username, password, root_password):
    
    sha256_input_root_password = sha256(root_password).hexdigest()
    print(sha256_input_root_password)
    


# 新客户连接调用此函数
def new_connect(client_executor, address):
    print('来自%s:%s的连接' % address)
    





# 接收客户端请求函数组

# 接收客户端密码函数
def receive_password():
    listener.send('SafeChecking'.encode('utf-8'))
    recvData = listener.recv(1024)
    if (recvData == "1"):# 非管理员用户
        username = listener.recv(1024)
        password = listener.recv(1024)
    elif (recvData == "2"):# 管理员用户
        root_password = listener.recv(1024)
    else:
        listener.send("请求错误！")

    return username, password, root_password








# 声明主函数

def run():
    client_executor, address = listener.accept()
    new_connect(client_executor, address)
    username, password, root_password = receive_password()#保存客户密码输入
    checking(username.decode(), password.decode(), root_password.decode())

run()
# 死循环等待，若有客户连接，分配线程处理客户请求，继续等待，如此循环
#while True:
#    client_executor, address = listener.accept()
#    tg = threading.Thread(target=run, args=(client_executor, address))
#    tg.start()