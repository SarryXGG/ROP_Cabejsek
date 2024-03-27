#include <iostream>

using namespace std;

int main() {
    double a, b, c;

    // Načtení tří čísel od uživatele
    cout << "Zadejte tri cisla oddelena mezerou: ";
    cin >> a >> b >> c;

    // Zjištění, zda je některé z čísel záporné
    if (a < 0 || b < 0 || c < 0) {
        cout << "Ano, nektere z cisel je zaporne." << endl;
    }
    else {
        cout << "Ne, zadne z cisel neni zaporne." << endl;
    }

    return 0;
}
