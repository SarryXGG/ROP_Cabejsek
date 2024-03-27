#include <iostream>
#include <vector>

using namespace std;

int main() {
    int N;
    cout << "Zadejte cele cislo N: ";
    cin >> N;

    // Inicializace vektoru pro ulozeni znaku
    vector<char> posloupnost(N);

    // Načtení znaků posloupnosti
    cout << "Zadejte " << N << " znaku: ";
    for (int i = 0; i < N; ++i) {
        cin >> posloupnost[i];
    }

    // Inicializace proměnných pro počet a výpis znaků dělitelných 3
    int pocetDelitelnych = 0;
    cout << "Znaky s ASCII kódem dělitelným 3: ";
    for (char znak : posloupnost) {
        if (znak % 3 == 0) {
            cout << znak << " (" << int(znak) << ") ";
            pocetDelitelnych++;
        }
    }

    // Výpis počtu nalezených znaků
    cout << "\nPocet znaku s ASCII kódem dělitelným 3: " << pocetDelitelnych << endl;

    return 0;
}
