#include <iostream>
using namespace std;

class Contacts
{
private:
	string fio;
	string per_number;
	string mobile_phone;
	string additional_info;

public:
	Contacts();
	Contacts(string fio_, string per_number_, string mobile_phone_, string additional_info_);
	Contacts(const Contacts& contact);
	~Contacts();
	string get_fio() { return this->fio; }
	string get_per_number() { return this->per_number; }
	string get_mobile_phone() { return this->mobile_phone; }
	string get_additional_info() { return this->additional_info; }
};
int main()
{
	cout << "Input number of contacts" << endl;
	int n;
	cin >> n;
	Contacts* c = new Contacts[n];
	string fio_, per_number_, mobile_phone_, additional_info_;
	for (int i = 0; i < n; ++i)
	{
		cout << "Input fio: "; cin >> fio_; cout << endl;
		cout << "Input per_number: "; cin >> per_number_; cout << endl;
		cout << "Input mobile phone: "; cin >> mobile_phone_; cout << endl;
		cout << "Input additional info: "; cin >> additional_info_; cout << endl;
		Contacts buff(fio_, per_number_, mobile_phone_, additional_info_);
		c[i] = buff;
	}
	for (int i = 0; i < n; ++i)
	{
		cout << "Contact# " << i + 1 << ":" << endl;
		cout << c[i].get_fio() << "\tpersonal number: " << c[i].get_per_number() << "\tmobile phone: " << c[i].get_mobile_phone() << "\tadditional info: " << c[i].get_additional_info() << endl;
	}
}

Contacts::Contacts()
{
	this->fio = "Ivanov_A.O";
	this->per_number = "+380503456789";
	this->mobile_phone = "+380671234567";
	this->additional_info = "From company: name_company";
}

Contacts::Contacts(string fio_, string per_number_, string mobile_phone_, string additional_info_)
{
	this->fio = fio_;
	this->per_number = per_number_;
	this->mobile_phone = mobile_phone_;
	this->additional_info = additional_info_;
}

Contacts::Contacts(const Contacts& contact)
{
	this->fio = contact.fio;
	this->per_number = contact.per_number;
	this->mobile_phone = contact.mobile_phone;
	this->additional_info = contact.additional_info;
}

Contacts::~Contacts()
{
	//cout << "Destructing Contacts: " << fio<<",\t"<<per_number<<",\t"<<mobile_phone<<",\t"<<additional_info << '\n';
}
