/**
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package softheon.wallet.api.client.models;

import com.fasterxml.jackson.annotation.JsonProperty;

/**
 * The request model sent by the client for adding new credit cards to the
 * payment platform.
 */
public class CreditCardRequestModel {
    /**
     * The number on the credit card.
     */
    @JsonProperty(value = "cardNumber", required = true)
    private String cardNumber;

    /**
     * The security, or CVV code, on the card.
     */
    @JsonProperty(value = "securityCode", required = true)
    private String securityCode;

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
     * The client application provided reference ID for the credit card.
     */
    @JsonProperty(value = "referenceId")
    private String referenceId;

    /**
     * The url that the client will be redirected to after the credit card has
     * been created.
     */
    @JsonProperty(value = "redirectUrl")
    private String redirectUrl;

    /**
     * Get the cardNumber value.
     *
     * @return the cardNumber value
     */
    public String cardNumber() {
        return this.cardNumber;
    }

    /**
     * Set the cardNumber value.
     *
     * @param cardNumber the cardNumber value to set
     * @return the CreditCardRequestModel object itself.
     */
    public CreditCardRequestModel withCardNumber(String cardNumber) {
        this.cardNumber = cardNumber;
        return this;
    }

    /**
     * Get the securityCode value.
     *
     * @return the securityCode value
     */
    public String securityCode() {
        return this.securityCode;
    }

    /**
     * Set the securityCode value.
     *
     * @param securityCode the securityCode value to set
     * @return the CreditCardRequestModel object itself.
     */
    public CreditCardRequestModel withSecurityCode(String securityCode) {
        this.securityCode = securityCode;
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
     * @return the CreditCardRequestModel object itself.
     */
    public CreditCardRequestModel withExpirationMonth(int expirationMonth) {
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
     * @return the CreditCardRequestModel object itself.
     */
    public CreditCardRequestModel withExpirationYear(int expirationYear) {
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
     * @return the CreditCardRequestModel object itself.
     */
    public CreditCardRequestModel withCardHolderName(String cardHolderName) {
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
     * @return the CreditCardRequestModel object itself.
     */
    public CreditCardRequestModel withBillingAddress(Address billingAddress) {
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
     * @return the CreditCardRequestModel object itself.
     */
    public CreditCardRequestModel withEmail(String email) {
        this.email = email;
        return this;
    }

    /**
     * Get the referenceId value.
     *
     * @return the referenceId value
     */
    public String referenceId() {
        return this.referenceId;
    }

    /**
     * Set the referenceId value.
     *
     * @param referenceId the referenceId value to set
     * @return the CreditCardRequestModel object itself.
     */
    public CreditCardRequestModel withReferenceId(String referenceId) {
        this.referenceId = referenceId;
        return this;
    }

    /**
     * Get the redirectUrl value.
     *
     * @return the redirectUrl value
     */
    public String redirectUrl() {
        return this.redirectUrl;
    }

    /**
     * Set the redirectUrl value.
     *
     * @param redirectUrl the redirectUrl value to set
     * @return the CreditCardRequestModel object itself.
     */
    public CreditCardRequestModel withRedirectUrl(String redirectUrl) {
        this.redirectUrl = redirectUrl;
        return this;
    }

}