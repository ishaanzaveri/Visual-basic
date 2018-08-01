#include <iostream>

using namespace std; 

int main(){
	int List[10];
	bool swapped = False;
	int temp;
	for (int i = 0; i < 10; i++){
		cout << "Enter element "<< (i+1) << endl;
		cin >> List[i];
	}
	for (int i = 0; i < 10; i++){
		for (int j = 0; j < 10 - i; j++){
			if (List[j]>List[j+1]){
				temp = List[j];
				List[j]=List[j+1];
				List[j+1]=temp;
			}
		}
	}

	for (int i = 0; i < 10; i++){
		cout << List[i] << " ";
		
	}

	return 0;
}