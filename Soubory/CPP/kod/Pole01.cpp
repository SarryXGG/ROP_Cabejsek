#include <iostream>
#include <vector>

using namespace std;

int main() {
    int n;

    // Načtení celého čísla n
    cout << "Zadejte pocet prvku posloupnosti: ";
    cin >> n;

    // Vytvoření pole pro posloupnost znaků
    vector<char> posloupnost(n);

    // Načtení posloupnosti znaků do pole
    cout << "Zadejte " << n << "-prvkovou posloupnost znaku: ";
    for (int i = 0; i < n; ++i) {
        cin >> posloupnost[i];
    }

    // Výpis posloupnosti v obráceném pořadí
    cout << "Posloupnost v obracenem poradi: ";
    for (int i = n - 1; i >= 0; --i) {
        cout << posloupnost[i] << " ";
    }
    cout << endl;

    return 0;
}
