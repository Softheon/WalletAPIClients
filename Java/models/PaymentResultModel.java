/**
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package softheon.wallet.api.client.models;

import com.fasterxml.jackson.annotation.JsonProperty;

/**
 * The model sent to the client as a part of the payment model.
 * Provides details on the payment result.
 */
public class PaymentResultModel {
    /**
     * The current status of the payment. Possible values include: 'Unknown',
     * 'New', 'Authorized', 'Captured', 'Expired', 'Declined', 'Failed',
     * 'Cancelled', 'Charge Back', 'Refunded', 'Partially Refunded'.
     */
    @JsonProperty(value = "status")
    private String status;

    /**
     * The payment result code.
     */
    @JsonProperty(value = "code")
    private String code;

    /**
     * The payment result message.
     */
    @JsonProperty(value = "message")
    private String message;

    /**
     * The unique ID of the provider account that was used to make this
     * payment.
     */
    @JsonProperty(value = "providerAccountId")
    private String providerAccountId;

    /**
     * Tthe merchant transaction identifier.
     */
    @JsonProperty(value = "merchantTransactionId")
    private String merchantTransactionId;

    /**
     * The merchant transaction fee.
     */
    @JsonProperty(value = "merchantTransactionFee")
    private Double merchantTransactionFee;

    /**
     * Get the status value.
     *
     * @return the status value
     */
    public String status() {
        return this.status;
    }

    /**
     * Set the status value.
     *
     * @param status the status value to set
     * @return the PaymentResultModel object itself.
     */
    public PaymentResultModel withStatus(String status) {
        this.status = status;
        return this;
    }

    /**
     * Get the code value.
     *
     * @return the code value
     */
    public String code() {
        return this.code;
    }

    /**
     * Set the code value.
     *
     * @param code the code value to set
     * @return the PaymentResultModel object itself.
     */
    public PaymentResultModel withCode(String code) {
        this.code = code;
        return this;
    }

    /**
     * Get the message value.
     *
     * @return the message value
     */
    public String message() {
        return this.message;
    }

    /**
     * Set the message value.
     *
     * @param message the message value to set
     * @return the PaymentResultModel object itself.
     */
    public PaymentResultModel withMessage(String message) {
        this.message = message;
        return this;
    }

    /**
     * Get the providerAccountId value.
     *
     * @return the providerAccountId value
     */
    public String providerAccountId() {
        return this.providerAccountId;
    }

    /**
     * Set the providerAccountId value.
     *
     * @param providerAccountId the providerAccountId value to set
     * @return the PaymentResultModel object itself.
     */
    public PaymentResultModel withProviderAccountId(String providerAccountId) {
        this.providerAccountId = providerAccountId;
        return this;
    }

    /**
     * Get the merchantTransactionId value.
     *
     * @return the merchantTransactionId value
     */
    public String merchantTransactionId() {
        return this.merchantTransactionId;
    }

    /**
     * Set the merchantTransactionId value.
     *
     * @param merchantTransactionId the merchantTransactionId value to set
     * @return the PaymentResultModel object itself.
     */
    public PaymentResultModel withMerchantTransactionId(String merchantTransactionId) {
        this.merchantTransactionId = merchantTransactionId;
        return this;
    }

    /**
     * Get the merchantTransactionFee value.
     *
     * @return the merchantTransactionFee value
     */
    public Double merchantTransactionFee() {
        return this.merchantTransactionFee;
    }

    /**
     * Set the merchantTransactionFee value.
     *
     * @param merchantTransactionFee the merchantTransactionFee value to set
     * @return the PaymentResultModel object itself.
     */
    public PaymentResultModel withMerchantTransactionFee(Double merchantTransactionFee) {
        this.merchantTransactionFee = merchantTransactionFee;
        return this;
    }

}
