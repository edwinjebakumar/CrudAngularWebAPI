export interface IInvoice {
    id: number;
    invNumber: number;
    custNumber: number;
    invDt: Date;
    amount: number;
    voidFlag: boolean;
    invoiceDetails?: any;
}
