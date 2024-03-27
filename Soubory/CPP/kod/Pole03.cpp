#include <iostream>
#include <vector>

using namespace std;

int main() {
    int n;

    // Načtení celého čísla n
    cout << "Zadejte pocet prvku posloupnosti: ";
    cin >> n;

    // Vytvoření pole pro posloupnost čísel
    vector<int> posloupnost(n);

    // Načtení posloupnosti čísel do pole
    cout << "Zadejte " << n << "-prvkovou posloupnost celych cisel: ";
    for (int i = 0; i < n; ++i) {
        cin >> posloupnost[i];
    }

    // Získání posledního prvku posloupnosti
    int posledni_prvek = posloupnost.back();

    // Proměnná pro kontrolu, zda existuje prvek větší než poslední prvek
    bool nalezeno = false;

    // Výpis všech prvků posloupnosti a jejich pozice, které jsou větší než poslední prvek
    cout << "Prvky vetsi nez posledni prvek (" << posledni_prvek << "):" << endl;
    for (int i = 0; i < n; ++i) {
        if (posloupnost[i] > posledni_prvek) {
            cout << "Prvek: " << posloupnost[i] << ", pozice: " << i + 1 << endl;
            nalezeno = true;
        }
    }

    // Pokud nebyl nalezen žádný prvek větší než poslední prvek, vypište o tom zprávu
    if (!nalezeno) {
        cout << "Zadny prvek neni vetsi nez posledni prvek." << endl;
    }

    return 0;
}
