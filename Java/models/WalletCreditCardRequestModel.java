/**
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package softheon.wallet.api.client.models;

import com.fasterxml.jackson.annotation.JsonProperty;

/**
 * Wallet credit card request model.
 */
public class WalletCreditCardRequestModel {
    /**
     * Gets or sets the payment token.
     */
    @JsonProperty(value = "paymentToken")
    private String paymentToken;

    /**
     * Gets or sets a value indicating whether this instance is default.
     */
    @JsonProperty(value = "isDefault")
    private Boolean isDefault;

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
     * @return the WalletCreditCardRequestModel object itself.
     */
    public WalletCreditCardRequestModel withPaymentToken(String paymentToken) {
        this.paymentToken = paymentToken;
        return this;
    }

    /**
     * Get the isDefault value.
     *
     * @return the isDefault value
     */
    public Boolean isDefault() {
        return this.isDefault;
    }

    /**
     * Set the isDefault value.
     *
     * @param isDefault the isDefault value to set
     * @return the WalletCreditCardRequestModel object itself.
     */
    public WalletCreditCardRequestModel withIsDefault(Boolean isDefault) {
        this.isDefault = isDefault;
        return this;
    }

}