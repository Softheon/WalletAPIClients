/**
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package walletapiv2.models;

import java.util.List;
import com.fasterxml.jackson.annotation.JsonProperty;

/**
 * Wallet Model.
 */
public class WalletModel {
    /**
     * Gets or sets the identifier.
     */
    @JsonProperty(value = "id", required = true)
    private int id;

    /**
     * Gets or sets the default token.
     */
    @JsonProperty(value = "defaultToken")
    private String defaultToken;

    /**
     * Gets or sets the credit cards.
     */
    @JsonProperty(value = "creditCards")
    private List<CreditCardModel> creditCards;

    /**
     * Gets or sets the bank accounts.
     */
    @JsonProperty(value = "bankAccounts")
    private List<BankAccountModel> bankAccounts;

    /**
     * Get gets or sets the identifier.
     *
     * @return the id value
     */
    public int id() {
        return this.id;
    }

    /**
     * Set gets or sets the identifier.
     *
     * @param id the id value to set
     * @return the WalletModel object itself.
     */
    public WalletModel withId(int id) {
        this.id = id;
        return this;
    }

    /**
     * Get gets or sets the default token.
     *
     * @return the defaultToken value
     */
    public String defaultToken() {
        return this.defaultToken;
    }

    /**
     * Set gets or sets the default token.
     *
     * @param defaultToken the defaultToken value to set
     * @return the WalletModel object itself.
     */
    public WalletModel withDefaultToken(String defaultToken) {
        this.defaultToken = defaultToken;
        return this;
    }

    /**
     * Get gets or sets the credit cards.
     *
     * @return the creditCards value
     */
    public List<CreditCardModel> creditCards() {
        return this.creditCards;
    }

    /**
     * Set gets or sets the credit cards.
     *
     * @param creditCards the creditCards value to set
     * @return the WalletModel object itself.
     */
    public WalletModel withCreditCards(List<CreditCardModel> creditCards) {
        this.creditCards = creditCards;
        return this;
    }

    /**
     * Get gets or sets the bank accounts.
     *
     * @return the bankAccounts value
     */
    public List<BankAccountModel> bankAccounts() {
        return this.bankAccounts;
    }

    /**
     * Set gets or sets the bank accounts.
     *
     * @param bankAccounts the bankAccounts value to set
     * @return the WalletModel object itself.
     */
    public WalletModel withBankAccounts(List<BankAccountModel> bankAccounts) {
        this.bankAccounts = bankAccounts;
        return this;
    }

}
