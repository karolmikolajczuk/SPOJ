#include <iostream>
#include <map>

/*
 * 0 - polnoc
 * 1 - poludnie
 * 2 - zachod
 * 3 - wschod
 * */

int main() {
	int number_of_tests;
	std::cin >> number_of_tests;

	while(number_of_tests--) {
		int nr_moves;
		std::cin >> nr_moves;

		std::map<int, int> moves;
		while (nr_moves--) {
			int directions, steps;
			std::cin >> directions >> steps;
			if (moves[directions] > 0) {
				moves[directions] += steps;
			} else {
				moves[directions] = steps;
			}
		}

		int* moves_result = new int[2];
		
		moves_result[0] = 0;
		moves_result[1] = 0;	
		
		for (auto iter = moves.begin(); iter != moves.end(); iter++) {
			switch(iter->first) {
				case 0:
					moves_result[0] += iter->second;
					break;
				case 1:
					moves_result[0] -= iter->second;
					break;
				case 2:
					moves_result[1] += iter->second;
					break;
				case 3:
					moves_result[1] -= iter->second;
					break;
			}
		}


		if (moves_result[0] == 0 && moves_result[1] == 0) {
			std::cout << "studnia" << std::endl;
		} else {
			if (moves_result[0] > 0) { std::cout << "0 " << moves_result[0] << std::endl; }
			else if (moves_result[0] < 0) { std::cout << "1 " << moves_result[0]*(-1) << std::endl; }
			if (moves_result[1] > 0) { std::cout << "2 " << moves_result[1] << std::endl; }
			else if (moves_result[1] < 0) { std::cout << "3 " << moves_result[1]*(-1) << std::endl; }
		}
	}	
	return 0;
}
