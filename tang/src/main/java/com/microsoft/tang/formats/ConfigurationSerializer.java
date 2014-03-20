package com.microsoft.tang.formats;

import com.microsoft.tang.Configuration;
import com.microsoft.tang.exceptions.BindException;

import java.io.File;
import java.io.IOException;

/**
 * Created by mweimer on 2014-03-19.
 */
public interface ConfigurationSerializer {


  /**
   * Stores the given Configuration in the given File.
   *
   * @param conf the Configuration to store
   * @param file the file to store the Configuration in
   * @throws java.io.IOException if there is an IO error in the process.
   */
  public void toFile(final Configuration conf, final File file) throws IOException;

  /**
   * Writes the Configuration to a byte[].
   *
   * @param conf
   * @return
   * @throws IOException
   */
  public byte[] toByteArray(final Configuration conf) throws IOException;

  /**
   * Writes the Configuration as a String.
   *
   * @param configuration
   * @return a String representation of the Configuration
   */
  public String toString(final Configuration configuration);


  /**
   * Loads a Configuration from a File created with toFile().
   *
   * @param file the File to read from.
   * @return the Configuration stored in the file.
   * @throws IOException   if the File can't be read or parsed
   * @throws BindException if the file contains an illegal Configuration
   */
  public Configuration fromFile(final File file) throws IOException, BindException;


  /**
   * Loads a Configuration from a byte[] created with toByteArray().
   *
   * @param theBytes the bytes to deserialize.
   * @return the Configuration stored.
   * @throws IOException   if the byte[] can't be deserialized
   * @throws BindException if the byte[] contains an illegal Configuration.
   */

  public Configuration fromByteArray(final byte[] theBytes) throws IOException, BindException;

  /**
   * Decodes a String generated via toString()
   *
   * @param theString to be parsed
   * @return the Configuration stored in theString.
   * @throws IOException   if theString can't be parsed.
   * @throws BindException if theString contains an illegal Configuration.
   */
  public Configuration fromString(final String theString) throws IOException, BindException;
}
