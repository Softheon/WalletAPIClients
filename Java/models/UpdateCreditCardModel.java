/**
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package softheon.wallet.api.client.models;

import com.fasterxml.jackson.annotation.JsonProperty;

/**
 * The request model sent by the client for updating credit cards in the
 * payment platform.
 */
public class UpdateCreditCardModel {
    /**
     * The payment token for the credit card.
     */
    @JsonProperty(value = "token", required = true)
    private String token;

    /**
     * The expiration month of the credit card.
     */
    @JsonProperty(value = "expirationMonth", required = true)
    private int expirationMonth;

    /**
     * The expiration year of the credit card.
     */
    @JsonProperty(value = "expirationYear", required = true)
    private int expirationYear;

    /**
     * The name of the cardholder, as it appears on the front of the credit
     * card.
     */
    @JsonProperty(value = "cardHolderName", required = true)
    private String cardHolderName;

    /**
     * The billing address for the credit card holder..
     */
    @JsonProperty(value = "billingAddress", required = true)
    private Address billingAddress;

    /**
     * A valid email address for the card holder.
     */
    @JsonProperty(value = "email", required = true)
    private String email;

    /**
     * Get the token value.
     *
     * @return the token value
     */
    public String token() {
        return this.token;
    }

    /**
     * Set the token value.
     *
     * @param token the token value to set
     * @return the UpdateCreditCardModel object itself.
     */
    public UpdateCreditCardModel withToken(String token) {
        this.token = token;
        return this;
    }

    /**
     * Get the expirationMonth value.
     *
     * @return the expirationMonth value
     */
    public int expirationMonth() {
        return this.expirationMonth;
    }

    /**
     * Set the expirationMonth value.
     *
     * @param expirationMonth the expirationMonth value to set
     * @return the UpdateCreditCardModel object itself.
     */
    public UpdateCreditCardModel withExpirationMonth(int expirationMonth) {
        this.expirationMonth = expirationMonth;
        return this;
    }

    /**
     * Get the expirationYear value.
     *
     * @return the expirationYear value
     */
    public int expirationYear() {
        return this.expirationYear;
    }

    /**
     * Set the expirationYear value.
     *
     * @param expirationYear the expirationYear value to set
     * @return the UpdateCreditCardModel object itself.
     */
    public UpdateCreditCardModel withExpirationYear(int expirationYear) {
        this.expirationYear = expirationYear;
        return this;
    }

    /**
     * Get the cardHolderName value.
     *
     * @return the cardHolderName value
     */
    public String cardHolderName() {
        return this.cardHolderName;
    }

    /**
     * Set the cardHolderName value.
     *
     * @param cardHolderName the cardHolderName value to set
     * @return the UpdateCreditCardModel object itself.
     */
    public UpdateCreditCardModel withCardHolderName(String cardHolderName) {
        this.cardHolderName = cardHolderName;
        return this;
    }

    /**
     * Get the billingAddress value.
     *
     * @return the billingAddress value
     */
    public Address billingAddress() {
        return this.billingAddress;
    }

    /**
     * Set the billingAddress value.
     *
     * @param billingAddress the billingAddress value to set
     * @return the UpdateCreditCardModel object itself.
     */
    public UpdateCreditCardModel withBillingAddress(Address billingAddress) {
        this.billingAddress = billingAddress;
        return this;
    }

    /**
     * Get the email value.
     *
     * @return the email value
     */
    public String email() {
        return this.email;
    }

    /**
     * Set the email value.
     *
     * @param email the email value to set
     * @return the UpdateCreditCardModel object itself.
     */
    public UpdateCreditCardModel withEmail(String email) {
        this.email = email;
        return this;
    }

}
