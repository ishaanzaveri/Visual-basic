// All Tasks c++
// Ishaan Zaveri 
#include <iostream>

using namespace std; 

int main () {
// variables 
	int i=0, heardNo = 0, j=0, maxUID = 1, week = 0; 
	float Milking1 = 0, Milking2=0, max = 0, sum = 0;
	int UID[1000], LessMilk[1000];
	float Milk[7000],MilkStore[1000];

//Task 1
	cout << "Enter No. of cows" << endl;
	cin >> heardNo;
	for (int i = 1; i <= heardNo; i++) {
	 	cout << "Enter UID" << endl;
	 	do {
	 		cin >> UID[i];
	 		if (UID[i] < 100 or UID[i]>999 ){
	 			cout << "error enter again " << endl;
	 		}
	 	}while (UID[i]<=100 and UID[i]>=999);
	 }

	 for (int i = 0; i <= 6 ; i++){
	  	for (int j = 1; j<=heardNo; j++ ){
	  		cout << "input Milk1 for cow " << UID[j] << endl;
	  		cin >> Milking1;
	  		cout << "input Milk2 for cow " << UID[j] << endl;
	  		cin >> Milking2;
	  		Milk[heardNo*i+j]= Milking1+Milking2;
	  	}
	  }
// Task 2 
	 for (int i = 0; i <= 6 ; i++){
	  	for (int j = 1; j<=heardNo; j++ ){
	  		sum = sum + Milk[heardNo*i+j];
	  	}
	  }
	  cout << "total yield for week = " << sum <<
	  "average yield for week is "<< sum/heardNo << endl;

//Task 3 
	  for (int i = 1; i<=heardNo;i++ ){
	  	for (int i = 0; i <= 6; i++){
	  		MilkStore[i]= MilkStore[i] + Milk[heardNo*j+i];
	  		if (Milk[heardNo*j+i]<12){
	  			LessMilk[i]= LessMilk[i]+1;
	  		}
	  	}
	  }
	  maxUID=UID[i];
	  max=MilkStore[i];
	  for (int i = 1; i <= heardNo;i++){
	  	if (MilkStore[i]>max){
	  		max=MilkStore[i];
	  		maxUID=UID[i];
	  	}
	  	if (LessMilk[i] >= 4){
	  		cout << "cow: " << UID[i] << "produced less than 12L of Milk " << endl;
	  	}
	  }
	 cout << "cow:" << maxUID << "produced the most milk:" << max << endl; 
	 return 0;
}