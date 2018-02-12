/**
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package softheon.wallet.api.client.models;

import com.fasterxml.jackson.annotation.JsonProperty;

/**
 * The response model that is returned to the client when a new payment
 * subscription is added to the platform.
 */
public class SubscriptionResponceModel {
    /**
     * Gets or sets the reference id.
     */
    @JsonProperty(value = "referenceId")
    private String referenceId;

    /**
     * Gets or sets the subscription state. Possible values include: 'Active',
     * 'Inactive', 'Expired'.
     */
    @JsonProperty(value = "state")
    private String state;

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
     * @return the SubscriptionResponceModel object itself.
     */
    public SubscriptionResponceModel withReferenceId(String referenceId) {
        this.referenceId = referenceId;
        return this;
    }

    /**
     * Get the state value.
     *
     * @return the state value
     */
    public String state() {
        return this.state;
    }

    /**
     * Set the state value.
     *
     * @param state the state value to set
     * @return the SubscriptionResponceModel object itself.
     */
    public SubscriptionResponceModel withState(String state) {
        this.state = state;
        return this;
    }

}