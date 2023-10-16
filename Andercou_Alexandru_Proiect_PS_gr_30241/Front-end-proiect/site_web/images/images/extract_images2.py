from pygoogle_image import image as pi

prompt=input("Give me a prompt")

images=pi.download(keywords=prompt,limit=1000)
print("imagini",images)