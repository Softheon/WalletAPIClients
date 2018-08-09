/**
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package walletapiv2.models;

import com.fasterxml.jackson.annotation.JsonProperty;

/**
 * The response model that is returned to the client when a new bank account is
 * added
 * to the platform.
 */
public class BankAccountResponseModel {
    /**
     * The payment token for the bank account.
     */
    @JsonProperty(value = "token")
    private String token;

    /**
     * The state that the bank acocunt is in. Possible values include:
     * 'Unknown', 'New', 'Pending', 'Authorized', 'Disabled'.
     */
    @JsonProperty(value = "bankAccountState")
    private String bankAccountState;

    /**
     * The url that the client will be redirected to after the bank account has
     * been created.
     */
    @JsonProperty(value = "redirectUrl")
    private String redirectUrl;

    /**
     * Get the payment token for the bank account.
     *
     * @return the token value
     */
    public String token() {
        return this.token;
    }

    /**
     * Set the payment token for the bank account.
     *
     * @param token the token value to set
     * @return the BankAccountResponseModel object itself.
     */
    public BankAccountResponseModel withToken(String token) {
        this.token = token;
        return this;
    }

    /**
     * Get the state that the bank acocunt is in. Possible values include: 'Unknown', 'New', 'Pending', 'Authorized', 'Disabled'.
     *
     * @return the bankAccountState value
     */
    public String bankAccountState() {
        return this.bankAccountState;
    }

    /**
     * Set the state that the bank acocunt is in. Possible values include: 'Unknown', 'New', 'Pending', 'Authorized', 'Disabled'.
     *
     * @param bankAccountState the bankAccountState value to set
     * @return the BankAccountResponseModel object itself.
     */
    public BankAccountResponseModel withBankAccountState(String bankAccountState) {
        this.bankAccountState = bankAccountState;
        return this;
    }

    /**
     * Get the url that the client will be redirected to after the bank account has been created.
     *
     * @return the redirectUrl value
     */
    public String redirectUrl() {
        return this.redirectUrl;
    }

    /**
     * Set the url that the client will be redirected to after the bank account has been created.
     *
     * @param redirectUrl the redirectUrl value to set
     * @return the BankAccountResponseModel object itself.
     */
    public BankAccountResponseModel withRedirectUrl(String redirectUrl) {
        this.redirectUrl = redirectUrl;
        return this;
    }

}
