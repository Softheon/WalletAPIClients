/**
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package softheon.wallet.api.client.models;

import com.fasterxml.jackson.annotation.JsonProperty;

/**
 * Defines a a funding source for a payment request.
 */
public class PaymentMethodModel {
    /**
     * The credit card or bank account token that will be used for payment.
     */
    @JsonProperty(value = "paymentToken", required = true)
    private String paymentToken;

    /**
     * The type of funding source that will be used for the payment. Possible
     * values include: 'Unknown', 'Credit Card', 'ACH'.
     */
    @JsonProperty(value = "type", required = true)
    private String type;

    /**
     * Get the paymentToken value.
     *
     * @return the paymentToken value
     */
    public String paymentToken() {
        return this.paymentToken;
    }

    /**
     * Set the paymentToken value.
     *
     * @param paymentToken the paymentToken value to set
     * @return the PaymentMethodModel object itself.
     */
    public PaymentMethodModel withPaymentToken(String paymentToken) {
        this.paymentToken = paymentToken;
        return this;
    }

    /**
     * Get the type value.
     *
     * @return the type value
     */
    public String type() {
        return this.type;
    }

    /**
     * Set the type value.
     *
     * @param type the type value to set
     * @return the PaymentMethodModel object itself.
     */
    public PaymentMethodModel withType(String type) {
        this.type = type;
        return this;
    }

}