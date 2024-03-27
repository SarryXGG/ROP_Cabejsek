#include <iostream>
#include <vector>

using namespace std;

int main() {
    int n;
    cout << "Zadejte cele cislo n: ";
    cin >> n;

    // Inicializace vektoru pro ulozeni prvku posloupnosti
    vector<int> posloupnost(n);

    // Nacteni prvku posloupnosti
    for (int i = 0; i < n; ++i) {
        cout << "Zadejte prvek cislo " << i + 1 << ": ";
        cin >> posloupnost[i];
    }

    // Inicializace promennych pro vypocet aritmetickeho prumeru delitelnych prvku
    int sumaDelenych = 0;
    int pocetDelenych = 0;

    // Prochazeni prvku posloupnosti a vypocet aritmetickeho prumeru delitelnych prvku
    for (int prvek : posloupnost) {
        if (prvek % 3 == 0) {
            sumaDelenych += prvek;
            pocetDelenych++;
        }
    }

    // Vypocet aritmetickeho prumeru delitelnych prvku
    if (pocetDelenych > 0) {
        double prumer = static_cast<double>(sumaDelenych) / pocetDelenych;
        cout << "Aritmeticky prumer delitelnych prvku: " << prumer << endl;
    }
    else {
        cout << "V posloupnosti nejsou zadne delitelne prvky." << endl;
    }

    // Vyhledani maximalniho prvku a jeho pozice v posloupnosti
    int maxPrvek = posloupnost[0];
    int poziceMaxPrvku = 0;
    for (int i = 1; i < n; ++i) {
        if (posloupnost[i] > maxPrvek) {
            maxPrvek = posloupnost[i];
            poziceMaxPrvku = i;
        }
    }

    cout << "Maximalni prvek v posloupnosti: " << maxPrvek << " na pozici " << poziceMaxPrvku + 1 << endl;

    return 0;
}
