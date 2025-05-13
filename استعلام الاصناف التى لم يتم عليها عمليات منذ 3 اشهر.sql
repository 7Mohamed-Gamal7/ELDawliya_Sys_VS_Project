--SELECT p.Product_ID, p.Product_Name, p.QTE_IN_STOCK
--FROM Tbl_Products p
--LEFT JOIN Tbl_InvoiceItems t
--ON p.Product_ID = t.Product_ID
--AND t.Invoice_Date >= DATEADD(MONTH,-3,GETDATE())
--WHERE t.Product_ID IS NULL;
SELECT 
    p.Product_ID, 
    p.Product_Name, 
    p.QTE_IN_STOCK,
    CASE 
        WHEN (SELECT MAX(t.Invoice_Date) 
              FROM Tbl_InvoiceItems t 
              WHERE t.Product_ID = p.Product_ID) IS NULL 
        THEN 'áã íÊã ÇÓÊÎÏÇãå Åáì ÇáÂä'
        ELSE CONVERT(VARCHAR, (SELECT MAX(t.Invoice_Date) 
                               FROM Tbl_InvoiceItems t 
                               WHERE t.Product_ID = p.Product_ID), 120)
    END AS Last_Operation
FROM Tbl_Products p
LEFT JOIN Tbl_InvoiceItems t
ON p.Product_ID = t.Product_ID
AND t.Invoice_Date >= DATEADD(MONTH, -3, GETDATE())
WHERE t.Product_ID IS NULL;

