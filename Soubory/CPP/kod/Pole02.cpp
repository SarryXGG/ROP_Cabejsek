#include <iostream>
#include <vector>

using namespace std;

int main() {
    int n;

    // Načtení celého čísla n
    cout << "Zadejte pocet prvku posloupnosti: ";
    cin >> n;

    // Vytvoření pole pro posloupnost celých čísel
    vector<int> posloupnost(n);

    // Načtení posloupnosti čísel do pole
    cout << "Zadejte " << n << "-prvkovou posloupnost celych cisel: ";
    for (int i = 0; i < n; ++i) {
        cin >> posloupnost[i];
    }

    // Výpočet aritmetického průměru prvků posloupnosti
    double prumer = 0;
    for (int i = 0; i < n; ++i) {
        prumer += posloupnost[i];
    }
    prumer /= n;

    // Výpis aritmetického průměru
    cout << "Aritmeticky prumer posloupnosti je: " << prumer << endl;

    // Výpis všech prvků posloupnosti, které jsou větší než aritmetický průměr
    cout << "Prvky vetsi nez prumer: ";
    for (int i = 0; i < n; ++i) {
        if (posloupnost[i] > prumer) {
            cout << posloupnost[i] << " ";
        }
    }
    cout << endl;

    return 0;
}
