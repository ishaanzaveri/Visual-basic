#include <iostream>

using namespace std; 

int main(){
	int List[10];
	bool swapped = false;
	int temp, i,num;
	cout << "Enter number of element" << endl;
	cin >> num;
	for (int i = 0; i < num; i++){
		cout << "Enter element "<< (i+1) << endl;
		cin >> List[i];
	}
	i = 0; 
	do{
		i++;
		for (int j = 0; j < num - i; j++){
			swapped = false;
			if (List[j]>List[j+1]){
				temp = List[j];
				List[j]=List[j+1];
				List[j+1]=temp;
				swapped = true;
			}
		}
	} while(swapped && i<num);

	for (int i = 0; i < num; i++){
		cout << List[i] << " ";
	}
	cout << "\n" << i << "\n";

	return 0;
}