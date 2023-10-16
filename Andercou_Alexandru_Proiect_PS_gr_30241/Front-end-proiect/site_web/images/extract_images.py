import requests
from bs4 import BeautifulSoup
import urllib.request

import getopt
import sys
 
argv = sys.argv[1:]
 
opts, args = getopt.getopt(argv, 'n:u:dp:dt')

print(opts)
import sys




pictures_url="https://www.google.com/search?q=pizza&sxsrf=APwXEdcDPdPzvMsYC8DzbK0utKqvCZHRgw:1685169147413&source=lnms&tbm=isch&sa=X&ved=2ahUKEwiszKuj8JT_AhVC3KQKHWENA_YQ_AUoAnoECAEQBA&biw=1536&bih=722&dpr=1.25"
#"https://www.bing.com/images/search?q=spaghetti+with+tomato+sauce&form=HDRSC4&first=1"
picture_names="pizza"
pictures_dest_path='C:\\Users\\Alexandru Andercou\\Desktop\\Front-end-proiect\\images\\'
pictures_dest_type="jpg"
pictures_dest_extention='.'+pictures_dest_type

for opt in opts:
    if opt[0]=="-n":
       picture_names=opt[1]
       
    if opt[0]=="-u":
       pictures_url=opt[1]   


       
     if opt[0]=="-dp":
       pictures_dest_path=opt[1] 
       
    if opt[0]=="-dt":
       pictures_dest_type=opt[1] 

#https://www.bing.com/images/search?q=salads&form=HDRSC4&first=1&cw=1465&ch=754
r = requests.get(pictures_url)

# check status code for response received
# success code - 200
#print(r)

# print content of request
#print(r.content)
html = BeautifulSoup(r.text, 'html.parser')
img_tags = html.find_all('img')
print(img_tags)
urls=[]
for img in img_tags:
  try:
   urls.append(img["src"])
  except:
    try:
     urls.append(img['data-src'])
    except:
      print("no url")

print(urls)
i=1
for url in urls:
      if url.find("http")>=0:
        urllib.request.urlretrieve(url, pictures_dest_path+picture_names+str(i)+pictures_dest_extention)
        i=i+1

