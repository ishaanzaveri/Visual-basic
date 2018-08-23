studentHeight[30]
input studentHeight[1]
min <- studentHeight[1]
max <- studentHeight[1]
for i <- 2 to 30 
	input studentHeight[i]
	if studentHeight[i]>max then 
		max = studentHeight[i]
	else if studentHeight[i]<min then 
		min = studentHeight[i]
	avg = avg + studentHeight[i]
next 
avg=avg/30
print max , min , avg 
