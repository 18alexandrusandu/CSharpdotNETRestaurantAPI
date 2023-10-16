import os 
import sys
folder_path="C:\\Users\\Alexandru Andercou\\Desktop\\Front-end-proiect\\images\\"


print("argv0:"+sys.argv[0])
if len(sys.argv)<=1:
  prompt=input("Give me a prompt")
else:
   prompt=sys.argv[1]

dir_list = os.listdir(folder_path)
print(dir_list)
for d in dir_list:
  if os.path.exists(folder_path+d):
    if d.find(prompt)>= 0 :
        os.remove(folder_path+d)