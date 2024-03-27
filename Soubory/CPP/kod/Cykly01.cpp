#include <iostream>

using namespace std;

int main() {
    int n;
    cout << "Zadejte cele cislo n: ";
    cin >> n;

    // Způsob a)
    int vypsaneRadky = 0;
    while (vypsaneRadky < n) {
        cout << "***" << endl;
        vypsaneRadky++;
    }

    return 0;
}
