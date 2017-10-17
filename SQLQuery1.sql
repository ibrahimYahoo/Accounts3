SELECT Date,InvoiceNo,ReferenceNo, Category,Description,AmountType,Income,Expense,Balance from CashBook WHERE Date BETWEEN '03/01/2017 12:44:38 AM' AND '10/17/2017 12:44:38 AM' AND (Income = 100 OR Expense = 100) AND InvoiceNo = 'ORD4'


SELECT Date,InvoiceNo, ReferenceNo, Category,Description,AmountType,Income,Expense,Balance from CashBook WHERE date BETWEEN @1 AND @2 AND (Income = 100 OR Expense = 100) AND InvoiceNo = 'ORD2' AND ReferenceNo = 'bb'


SELECT Date,InvoiceNo, ReferenceNo, Category,Description,AmountType,Income,Expense,Balance from CashBook WHERE date BETWEEN '03/01/2017 12:44:38 AM' AND '10/17/2017 12:44:38 AM' AND PId = 1002