/**
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package softheon.wallet.api.client.models;

import com.fasterxml.jackson.annotation.JsonProperty;

/**
 * The request model sent by the client for adding new bank accounts to the
 * payment platform.
 */
public class BankAccountRequestModel {
    /**
     * The bank account number.
     */
    @JsonProperty(value = "accountNumber", required = true)
    private String accountNumber;

    /**
     * The routing number of the bank where the bank account was opened.
     */
    @JsonProperty(value = "routingNumber", required = true)
    private String routingNumber;

    /**
     * The name of the individual or entity that is autorized to make
     * transactions for the bank account.
     */
    @JsonProperty(value = "accountHolderName", required = true)
    private String accountHolderName;

    /**
     * The mailing address for the account holder.
     */
    @JsonProperty(value = "accountHolderAddress", required = true)
    private Address accountHolderAddress;

    /**
     * The bank account type. Possible values include: 'Unknown', 'Checking',
     * 'Savings'.
     */
    @JsonProperty(value = "type", required = true)
    private String type;

    /**
     * The client application provided reference ID for the bank account.
     */
    @JsonProperty(value = "referenceId")
    private String referenceId;

    /**
     * The aribtrary nickname of the account, used as a way to identify the
     * account.
     */
    @JsonProperty(value = "nickname")
    private String nickname;

    /**
     * The email address for the account holder.
     */
    @JsonProperty(value = "email", required = true)
    private String email;

    /**
     * The url that the client will be redirected to after the bank account has
     * been created.
     */
    @JsonProperty(value = "redirectUrl")
    private String redirectUrl;

    /**
     * Get the accountNumber value.
     *
     * @return the accountNumber value
     */
    public String accountNumber() {
        return this.accountNumber;
    }

    /**
     * Set the accountNumber value.
     *
     * @param accountNumber the accountNumber value to set
     * @return the BankAccountRequestModel object itself.
     */
    public BankAccountRequestModel withAccountNumber(String accountNumber) {
        this.accountNumber = accountNumber;
        return this;
    }

    /**
     * Get the routingNumber value.
     *
     * @return the routingNumber value
     */
    public String routingNumber() {
        return this.routingNumber;
    }

    /**
     * Set the routingNumber value.
     *
     * @param routingNumber the routingNumber value to set
     * @return the BankAccountRequestModel object itself.
     */
    public BankAccountRequestModel withRoutingNumber(String routingNumber) {
        this.routingNumber = routingNumber;
        return this;
    }

    /**
     * Get the accountHolderName value.
     *
     * @return the accountHolderName value
     */
    public String accountHolderName() {
        return this.accountHolderName;
    }

    /**
     * Set the accountHolderName value.
     *
     * @param accountHolderName the accountHolderName value to set
     * @return the BankAccountRequestModel object itself.
     */
    public BankAccountRequestModel withAccountHolderName(String accountHolderName) {
        this.accountHolderName = accountHolderName;
        return this;
    }

    /**
     * Get the accountHolderAddress value.
     *
     * @return the accountHolderAddress value
     */
    public Address accountHolderAddress() {
        return this.accountHolderAddress;
    }

    /**
     * Set the accountHolderAddress value.
     *
     * @param accountHolderAddress the accountHolderAddress value to set
     * @return the BankAccountRequestModel object itself.
     */
    public BankAccountRequestModel withAccountHolderAddress(Address accountHolderAddress) {
        this.accountHolderAddress = accountHolderAddress;
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
     * @return the BankAccountRequestModel object itself.
     */
    public BankAccountRequestModel withType(String type) {
        this.type = type;
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
     * @return the BankAccountRequestModel object itself.
     */
    public BankAccountRequestModel withReferenceId(String referenceId) {
        this.referenceId = referenceId;
        return this;
    }

    /**
     * Get the nickname value.
     *
     * @return the nickname value
     */
    public String nickname() {
        return this.nickname;
    }

    /**
     * Set the nickname value.
     *
     * @param nickname the nickname value to set
     * @return the BankAccountRequestModel object itself.
     */
    public BankAccountRequestModel withNickname(String nickname) {
        this.nickname = nickname;
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
     * @return the BankAccountRequestModel object itself.
     */
    public BankAccountRequestModel withEmail(String email) {
        this.email = email;
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
     * @return the BankAccountRequestModel object itself.
     */
    public BankAccountRequestModel withRedirectUrl(String redirectUrl) {
        this.redirectUrl = redirectUrl;
        return this;
    }

}
