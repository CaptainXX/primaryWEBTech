import requests
import json

headers = {"Authorization": "ffeefeb1dcd175da6de1e3d5373c633dc8d1ff32"} # token

#如果get()方法里没有headers参数，则会返回如下结果：（表示要求认证）

# {u'documentation_url': u'https://developer.github.com/v3', u'message': u'Requires authentication'}

# 但并不是所有的方法都必须要带上headers参数

# 获取个人信息（将kylinlin替换为任意的帐户名都可以）

response = requests.get("https://api.github.com/repos/CaptainXX/primaryWEBTech/commits", headers=headers)
r = response.json()
with open("../response.json", "w") as j:
    j.truncate()
    j.write("[")

if response.status_code == 200:    
    for i in range(0, 3):
        print(i)
        print("sha:", r[i]["sha"])
        print("author:", r[i]["commit"]["author"]["name"])
        print("date:", r[i]["commit"]["author"]["date"])
        print("message:", r[i]["commit"]["message"])
        with open("../response.json", "a") as j:
            json.dump(r[i], j)
            if i != 2:
                j.write(",")
    with open("../response.json", "a") as j:
        j.write("]")
    print("文件写入完成")
else:
    print(response.status_code)
