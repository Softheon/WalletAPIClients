/**
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package walletapiv2.models;

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
     * Get gets or sets the payment token.
     *
     * @return the paymentToken value
     */
    public String paymentToken() {
        return this.paymentToken;
    }

    /**
     * Set gets or sets the payment token.
     *
     * @param paymentToken the paymentToken value to set
     * @return the WalletCreditCardRequestModel object itself.
     */
    public WalletCreditCardRequestModel withPaymentToken(String paymentToken) {
        this.paymentToken = paymentToken;
        return this;
    }

    /**
     * Get gets or sets a value indicating whether this instance is default.
     *
     * @return the isDefault value
     */
    public Boolean isDefault() {
        return this.isDefault;
    }

    /**
     * Set gets or sets a value indicating whether this instance is default.
     *
     * @param isDefault the isDefault value to set
     * @return the WalletCreditCardRequestModel object itself.
     */
    public WalletCreditCardRequestModel withIsDefault(Boolean isDefault) {
        this.isDefault = isDefault;
        return this;
    }

}
