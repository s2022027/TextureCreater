import UnityEditor
import UnityEngine
import cv2, matplotlib
import numpy as np
import matplotlib.pyplot as plt
from rembg import remove
import sys
import os
import clr
clr.AddReference('UnityEngine')
import UnityEngine
from UnityEngine import *


f = open('Assets/Resources/FileName.txt','r',encoding='UTF-8')
data = f.read()
animal = str(data)
UnityEngine.Debug.Log(type(animal))
UnityEngine.Debug.Log(animal)

path = "img"
files = os.listdir(path)


input_path = 'img/'+animal+'.jpg'
output_path = 'mask/'+animal+'_output.jpg'


if not os.path.isfile(input_path):
    print("File not found")
    sys.exit()


input = cv2.imread(input_path)
output = remove(input)
cv2.imwrite(output_path, output)

def imshow(img):
    
    ret, encoded = cv2.imencode(".jpg", img)
    display(Image(encoded))


bcbk = output_path

 
bcbk = cv2.imread(bcbk)


hsv = cv2.cvtColor(bcbk, cv2.COLOR_BGR2HSV)


bin_img = cv2.inRange(hsv, (0, 10, 0), (255, 255, 255))


mu = cv2.moments(bin_img, False)
x,y= int(mu["m10"]/mu["m00"]) , int(mu["m01"]/mu["m00"])


tex_img = bcbk[y - 50 : y + 50, x - 50: x + 50]


cv2.imwrite("Assets/Resources/"+animal+"_texture_test.jpg", tex_img)


UnityEngine.Debug.Log("Complete!")

f.close()
