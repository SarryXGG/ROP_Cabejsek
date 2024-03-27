#include <iostream>
#include <cstdlib>
#include <ctime>

using namespace std;

int main() {
    int n;
    cout << "Zadejte pocet cisel: ";
    cin >> n;

    srand(time(nullptr));

    int soucet_cislic = 0;

    cout << "Generovane znaky:" << endl;
    for (int i = 0; i < n; ++i) {
        int ascii_kod = rand() % (100 - 33 + 1) + 33;
        char znak = char(ascii_kod);

        cout << znak;

        if (znak >= '0' && znak <= '9') {
            soucet_cislic += (znak - '0');
        }

        if (znak >= 'A' && znak <= 'Z') {
            char male_pismeno = char(znak + ('a' - 'A'));
            cout << " (" << male_pismeno << ")";
        }
        else if (znak >= 'a' && znak <= 'z') {
            char velke_pismeno = char(znak - ('a' - 'A'));
            cout << " (" << velke_pismeno << ")";
        }

        cout << endl;
    }

    cout << "Soucet cisel: " << soucet_cislic << endl;

    return 0;
}
