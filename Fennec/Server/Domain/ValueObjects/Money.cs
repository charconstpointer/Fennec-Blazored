using Fennec.Server.Domain.Enums;

namespace Fennec.Server.Domain.ValueObjects
{
    public class Money
    {
        public float Amount { get; }
        public Currency Currency { get; }

        private Money(float amount, Currency currency)
        {
            Amount = amount;
            Currency = currency;
        }

        private static Money ConvertCurrency(Money money, Currency currency)
        {
            return new Money(0.0f, Currency.Dollar);
        }

        public Money Create(float amount, Currency currency)
            => new Money(amount, currency);

        public Money Convert(Money money, Currency currency)
            => ConvertCurrency(money, currency);
    }
}