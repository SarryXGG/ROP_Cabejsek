#include <iostream>
#include <string>

using namespace std;

int main() {
    char volba;

    // Výpis možností jídel
    cout << "s - snidane" << endl;
    cout << "o - obed" << endl;
    cout << "v - vecere" << endl;
    cout << "z - zadne jidlo" << endl;
    cout << "konec - ukonci program" << endl;

    // Načtení volby od uživatele
    cout << "Zvolte jedno jidlo nebo konec: ";
    cin >> volba;

    // Výpis vybraného jídla nebo oznámení o neobjednaném jídle
    switch (volba) {
    case 's':
        cout << "Objednal jste si snidani." << endl;
        break;
    case 'o':
        cout << "Objednal jste si obed." << endl;
        break;
    case 'v':
        cout << "Objednal jste si veceri." << endl;
        break;
    case 'z':
        cout << "Nebudete si objednavat zadne jidlo." << endl;
        break;
    case 'k':
        cout << "Ukoncuji program." << endl;
        break;
    default:
        cout << "Neplatna volba." << endl;
        break;
    }

    return 0;
}
