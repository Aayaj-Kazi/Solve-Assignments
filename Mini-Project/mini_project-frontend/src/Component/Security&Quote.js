export class Security {
  constructor(securityID, identifier, securityName, assetClass,quotesCount) {
    this.securityID = securityID;
    this.identifier = identifier;
    this.securityName = securityName;
    this.assetClass = assetClass;
    this.quotesCount = quotesCount;
  }
}

export class Quotes {
  constructor(quoteID, date, quotesAmt,provider, quoteType, securityID) {
    this.quoteID = quoteID;
    this.date = date;
    this.quotesAmt = quotesAmt;
    this.provider=provider;
    this.quoteType = quoteType;
    this.securityID = securityID;
  }
}
