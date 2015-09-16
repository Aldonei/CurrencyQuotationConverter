# CurrencyQuotationConverter
Convert currency according to CVS file from Banco Central

1. O programa recebe os 4 parâmetros.
2. Valida a entrada de dados.
3. Busca no http://www4.bcb.gov.br/Download/fechamento/20150915.csv (ano, mês, dia).
4. Varre o arquivo CSV procurando pelo valor da variável FROM e TO e seus respectivos valores no campo Taxa Compra.
5. Divide o valor FROM pelo valor TO e multiplica pela variável VALUE e obtem o valor da Cotação daquele dia.

Enunciado.
public BigDecimal currencyQuotation(String from, String to, Number value, String quotation);
Where:

