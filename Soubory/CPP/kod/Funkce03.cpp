#include <iostream>

using namespace std;

bool obsahujeLichCifru(int cislo) {
    while (cislo > 0) {
        int cifra = cislo % 10;
        if (cifra % 2 != 0) {
            return true;
        }
        cislo /= 10;
    }
    return false;
}

int main() {
    int cislo;
    cout << "Zadejte cele kladne cislo: ";
    cin >> cislo;

    if (obsahujeLichCifru(cislo)) {
        cout << "Zadane cislo obsahuje lichou cifru." << endl;
    }
    else {
        cout << "Zadane cislo neobsahuje lichou cifru." << endl;
    }

    return 0;
}
