/**
 *
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for license information.
 *
 */

package com.microsoft.rest;

/**
 * Exception indicating a service operation has timed out.
 */
public class ServiceTimeoutException extends ServiceException {

    private static final long serialVersionUID = 6612846403178749361L;

    /**
     * Construct a ServiceTimeoutException instance with default parameters.
     */
    public ServiceTimeoutException() {
    }

    /**
     * Construct a ServiceTimeoutException instance with the specified message.
     * 
     * @param message exception message
     */
    public ServiceTimeoutException(String message) {
        super(message);
    }

    /**
     * Construct a ServiceTimeoutException instance with specified message and
     * cause.
     * 
     * @param message exception message
     * @param cause exception that caused this exception to occur
     */
    public ServiceTimeoutException(String message, Throwable cause) {
        super(message, cause);
    }

    /**
     * Construct a ServiceTimeoutException instance with the specified cause.
     * 
     * @param cause exception that caused this exception to occur
     */
    public ServiceTimeoutException(Throwable cause) {
        super(cause);
    }
}
