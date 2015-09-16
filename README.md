# CurrencyQuotationConverter
Convert currency according to CVS file from Banco Central

Simplismente execute este arquivo para rodar o programa.
..\CurrencyConverterApplication\bin\Debug\CurrencyConverterApplication.exe

Ou faça o download da aplicação e abra do Visual Studio para ver o código fonte.
Desenvolvido no Visual Studio 2013 Professional

1. O programa recebe os 4 parâmetros.
2. Valida a entrada de dados.
3. Busca no http://www4.bcb.gov.br/Download/fechamento/20150915.csv (ano, mês, dia).
4. Varre o arquivo CSV procurando pelo valor da variável FROM e TO e seus respectivos valores no campo Taxa Compra.
5. Divide o valor FROM pelo valor TO e multiplica pela variável VALUE e obtem o valor da Cotação daquele dia.

Enunciado.
public BigDecimal currencyQuotation(String from, String to, Number value, String quotation);
Where:
1. from: String with the currency name (example "USD") you want to convert;
2. to: String with the currency name (example "EUR") you want to see the result;
3. value: The value that should be converted. The currency of this value will be expressed in the “from” parameter;
4. quotation: A date as String in the format “dd/MM/yyyy”;

Restrictions:
1. You shall not work with non-native classes / libraries;
2. If the from or to parameters are not valid, an exception must be thrown;
3. If the value is smaller than zero, an exception must be thrown;
4. For non-working days (Saturday and Sunday, ignoring holidays) takes the quotation from the immediately preceding business day. 
If the quotation of the previous day is not available, an exception must be thrown;
5. If the quotation date is not available, an exception must be thrown;
6. The data source used will be the Brazilian central bank CSV file available at:
http://www4.bcb.gov.br/pec/taxas/batch/cotacaomoedas.asp?id=txtodas
7. The return value should be rounded to two decimal places. 
8. You must convert the currency through rate "Taxa Compra".

Example:
currencyQuotation("USD", "EUR", 100.00, "20/11/2014") = 79.69
Data source:
20/11/2014 – 220 – A – USD - 2,54400000
20/11/2014 - 978 - B - EUR - 3,19170000
