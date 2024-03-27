#include <iostream>
#include <cmath>

using namespace std;

int main() {
    double odvesna1, odvesna2;

    // Nacteni delky prvni odvesny v metrech
    cout << "Zadejte delku prvni odvesny v metrech: ";
    cin >> odvesna1;
    // Nacteni delky druhe odvesny v metrech
    cout << "Zadejte delku druhe odvesny v metrech: ";
    cin >> odvesna2;

    // Vypocet delky prepony (treti strany) v kilometrech
    double prepona = sqrt(pow(odvesna1, 2) + pow(odvesna2, 2)) / 1000;

    // Vypis vysledku
    cout << "Delka treti strany (prepony) je: " << prepona << " kilometru" << endl;

    return 0;
}
