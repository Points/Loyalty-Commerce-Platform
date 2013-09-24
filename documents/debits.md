## Debits

A debit is a transaction that takes points out of a loyalty program member’s account. Creating a debit object triggers the removal of points. A record of the debit is kept that can later be retrieved. A debit requires a member validation that has not been previously used for another transaction. Debits are stored for each loyalty program under /lps/<lp-id>/debits/.

#### Properties

<table>
    <thead>
        <tr>
            <th>Field</th>
            <th>Description</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>amount</td>
            <td>The number of points deducted from the member's account. Must be a positive integer.</td>
        </tr>
        <tr>
            <td>memberValidation</td>
            <td>Link to a member validation that identifies the member's account that was debited.</td>
        </tr>
        <tr>
            <td>status</td>
            <td>The status of the debit. Must be either success or failure.</td>
        </tr>
        <tr>
            <td>transactionId</td>
            <td>A transaction ID that can be used to reconcile the debit against the loyalty partner's records.</td>
        </tr>
    </tbody>
</table>
