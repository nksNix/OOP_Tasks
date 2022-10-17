#include <iostream>
using namespace std;

class Fraction
{
private:
	int numerator;
	int denominator;
public:
	void in_numerator();
	void in_denominator();
	int get_numerator()const;
	int get_denominator()const;
	void set_numenator(int numerator_);
	void set_denominator(int denominator_);
	Fraction add_fr(const Fraction& fr);
	Fraction subtract_fr(const Fraction& fr);
	Fraction multiply_fr(const Fraction& fr);
	Fraction divide_fr(const Fraction& fr);
	friend ostream& operator<<(ostream& out, const Fraction& fr);
};

ostream& operator<<(ostream& out, const Fraction& fr)
{
	out << fr.numerator << "/" << fr.denominator;
	return out;
}

int main()
{
	Fraction first, second, result;
	first.in_numerator();
	first.in_denominator();
	second.in_numerator();
	second.in_denominator();
	cout << first << " + " << second << " = " << first.add_fr(second) << endl;
	cout << first << " - " << second << " = " << first.subtract_fr(second) << endl;
	cout << first << " * " << second << " = " << first.multiply_fr(second) << endl;
	cout << first << " : " << second << " = " << first.divide_fr(second) << endl;
}

void Fraction::in_numerator()
{
	cout << "Input numerator: ";
	cin >> this->numerator;
	cout << endl;
}

void Fraction::in_denominator()
{
	cout << "Input denominator: ";
	cin >> this->denominator;
	cout << endl;
}

int Fraction::get_numerator() const
{
	return numerator;
}

int Fraction::get_denominator() const
{
	return denominator;
}

void Fraction::set_numenator(int numerator_)
{
	this->numerator = numerator_;
}

void Fraction::set_denominator(int denominator_)
{
	this->denominator = denominator_;
}

Fraction Fraction::add_fr(const Fraction& fr)
{
	Fraction first, second, result;
	first.set_numenator(this->numerator * fr.get_denominator());
	first.set_denominator(this->denominator * fr.get_denominator());
	second.set_numenator(fr.get_numerator() * this->denominator);
	second.set_denominator(this->denominator * fr.get_denominator());

	result.set_numenator(first.get_numerator() + second.get_numerator());
	result.set_denominator(second.get_denominator());

	return result;
}

Fraction Fraction::subtract_fr(const Fraction& fr)
{
	Fraction first, second, result;
	first.set_numenator(this->numerator * fr.get_denominator());
	first.set_denominator(this->denominator * fr.get_denominator());
	second.set_numenator(fr.get_numerator() * this->denominator);
	second.set_denominator(this->denominator * fr.get_denominator());

	result.set_numenator(first.get_numerator() - second.get_numerator());
	result.set_denominator(second.get_denominator());

	return result;
}

Fraction Fraction::multiply_fr(const Fraction& fr)
{
	Fraction result;


	result.set_numenator(this->numerator * fr.get_numerator());
	result.set_denominator(this->denominator * fr.get_denominator());

	return result;
}

Fraction Fraction::divide_fr(const Fraction& fr)
{
	Fraction result;


	result.set_numenator(this->numerator * fr.get_denominator());
	result.set_denominator(this->denominator * fr.get_numerator());

	return result;
}
